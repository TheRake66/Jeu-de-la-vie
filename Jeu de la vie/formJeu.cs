using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_la_vie
{
    public partial class formJeu : Form
    {
        // -------------------------------------
        bool[,] lesCases;
        bool[,] lesCasesTemp;

        int nbLigns;
        int nbCols;
        int tailleCase;
        int espacementCases;

        Random unAlea;
        Graphics leGraph;
        SolidBrush brushMorte;
        SolidBrush brushVivante;

        bool drawOn;
        bool drawMode;
        int lastI;
        int lastJ;
        // -------------------------------------



        // ====================================================================
        public formJeu()
        {
            // -------------------------------------
            InitializeComponent();

            this.espacementCases = 1;
            this.unAlea = new Random();
            this.brushMorte = new SolidBrush(SystemColors.WindowFrame);
            this.brushVivante = new SolidBrush(Color.Yellow);

            redimenssioneCases();
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            OpenFileDialog fileDlg = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "*.*",
                Filter = "Tous les fichiers (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
            };


            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int i = 0;
                    int j = 0;
                    Bitmap pic = (Bitmap)Image.FromFile(fileDlg.FileName);

                    this.numericUpDownNbLignes.Value = pic.Height;
                    this.numericUpDownNbColonnes.Value = pic.Width;

                    for (int h = 0; h < pic.Height; h++)
                    {
                        for (int w = 0; w < pic.Width; w++)
                        {
                            // Change l'oppacite de chaque pixel
                            Color c = pic.GetPixel(w, h);

                            if (i < this.nbLigns && j < this.nbCols)
                            {
                                this.lesCases[i, j] = c.R + c.G + c.B < 384 ? true : false;
                            }
                            j++;
                        }
                        j = 0;
                        i++;
                    }
                }
                catch (Exception m)
                {
                    MessageBox.Show("Impossible d'ouvrir l'image !\n" +
                        "Message : " + m.Message,
                        "Jeu de la vie",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dessinerCases();
            }
            // -------------------------------------
        }
        private void ouvrirUnFichierjdlvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            OpenFileDialog fileDlg = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "*.jdlv",
                Filter = "Jeu de la vie (*.jdlv)|*.jdlv",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string chaine = File.ReadAllText(fileDlg.FileName);

                    int i = 0;
                    int j = 0;
                    foreach (string uneLigne in chaine.Split('\n'))
                    {
                        foreach (char uneCase in uneLigne)
                        {
                            if (i < this.nbLigns && j < this.nbCols)
                            {
                                this.lesCases[i, j] = uneCase == '1' ? true : false;
                            }
                            j++;
                        }
                        j = 0;
                        i++;
                    }
                }
                catch (Exception m)
                {
                    MessageBox.Show("Impossible d'ouvrir le plateau !\n" +
                        "Message : " + m.Message,
                        "Jeu de la vie",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dessinerCases();
            }
            // -------------------------------------
        }
        private void sauvegarderDansUnFichierjdlvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            SaveFileDialog fileDlg = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),

                DefaultExt = "*.jdlv",
                Filter = "Jeu de la vie (*.jdlv)|*.jdlv",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                string chaine = "";

                for (int i = 0; i < this.nbLigns; i++)
                {
                    for (int j = 0; j < this.nbCols; j++)
                    {
                        chaine += this.lesCases[i, j] ? "1" : "0";
                    }
                    chaine += "\n";
                }

                try
                {
                    File.WriteAllText(fileDlg.FileName, chaine.Substring(0, chaine.Length - 1));
                }
                catch (Exception m)
                {
                    MessageBox.Show("Impossible de sauvegarder le plateau !\n" +
                        "Message : " + m.Message,
                        "Jeu de la vie",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // -------------------------------------
            try
            {
                Process.Start("https://github.com/TheRake66/");
            }
            catch { }
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void numericUpDownNbLignes_ValueChanged(object sender, EventArgs e)
        {
            // -------------------------------------
            redimenssioneCases();
            // -------------------------------------
        }
        private void numericUpDownNbColonnes_ValueChanged(object sender, EventArgs e)
        {
            // -------------------------------------
            redimenssioneCases();
            // -------------------------------------
        }
        private void numericUpDownTailleCase_ValueChanged(object sender, EventArgs e)
        {
            // -------------------------------------
            redimenssioneCases();
            // -------------------------------------
        }
        private void buttonInverser_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            if (this.lesCases != null)
            {
                for (int i = 0; i < this.nbLigns; i++)
                {
                    for (int j = 0; j < this.nbCols; j++)
                    {
                        this.lesCases[i, j] = !this.lesCases[i, j];
                    }
                }

                dessinerCases();
            }
            // -------------------------------------
        }
        private void buttonGenerer_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            if (this.lesCases != null)
            {
                // Aleatoire les cases
                for (int i = 0; i < this.nbLigns; i++)
                {
                    for (int j = 0; j < this.nbCols; j++)
                    {
                        this.lesCases[i, j] = this.unAlea.Next(0, 2) == 1 ? true : false;
                    }
                }

                dessinerCases();
            }
            // -------------------------------------
        }
        private void buttonCreer_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            creerCases();
            // -------------------------------------
        }
        private void buttonDemarrer_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            this.timerDemarrer.Enabled = true;
            // -------------------------------------
        }
        private void buttonPause_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            this.timerDemarrer.Enabled = false;
            // -------------------------------------
        }
        private void buttonReinit_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            // Reset les cases
            if (this.lesCases != null)
            {
                for (int i = 0; i < this.nbLigns; i++)
                {
                    for (int j = 0; j < this.nbCols; j++)
                    {
                        this.lesCases[i, j] = false;
                    }
                }

                dessinerCases();
            }
            // -------------------------------------
        }
        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            nextGeneration();
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void numericUpDownVitesse_ValueChanged(object sender, EventArgs e)
        {
            // -------------------------------------
            this.timerDemarrer.Interval = (int)this.numericUpDownVitesse.Value;
            // -------------------------------------
        }
        private void timerDemarrer_Tick(object sender, EventArgs e)
        {
            // -------------------------------------
            nextGeneration();
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void panelPlateau_Paint(object sender, PaintEventArgs e)
        {
            // -------------------------------------
            dessinerCases();
            // -------------------------------------
        }
        private void panelPlateau_MouseDown(object sender, MouseEventArgs e)
        {
            // -------------------------------------
            this.drawOn = true;

            int ratio = this.tailleCase + this.espacementCases;
            int i = e.Y / ratio;
            int j = e.X / ratio;

            int x = j * ratio + this.espacementCases;
            int y = i * ratio + this.espacementCases;

            if (i >= 0 && i < this.nbLigns && j >= 0 && j < this.nbCols)
            {
                this.drawMode = !this.lesCases[i, j];

                this.lesCases[i, j] = this.drawMode;
                this.leGraph.FillRectangle(
                    this.drawMode ? this.brushVivante : this.brushMorte,
                    x, y,
                    this.tailleCase, this.tailleCase
                    );

                this.lastI = i;
                this.lastJ = j;
            }
            // -------------------------------------
        }
        private void panelPlateau_MouseMove(object sender, MouseEventArgs e)
        {
            // -------------------------------------
            if (this.drawOn)
            {
                int ratio = this.tailleCase + this.espacementCases;
                int i = e.Y / ratio;
                int j = e.X / ratio;

                if (
                    (i != this.lastI || j != this.lastJ)
                    &&
                    (i >= 0 && i < this.nbLigns && j >= 0 && j < this.nbCols)
                    )
                {
                    this.lastI = i;
                    this.lastJ = j;

                    int x = j * ratio + this.espacementCases;
                    int y = i * ratio + this.espacementCases;

                    this.lesCases[i, j] = this.drawMode;
                    this.leGraph.FillRectangle(
                        this.drawMode ? this.brushVivante : this.brushMorte,
                        x, y,
                        this.tailleCase, this.tailleCase
                        );
                }
            }
            // -------------------------------------
        }
        private void panelPlateau_MouseUp(object sender, MouseEventArgs e)
        {
            // -------------------------------------
            this.drawOn = false;
            this.lastI = 0;
            this.lastJ = 0;
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void redimenssioneCases()
        {
            // -------------------------------------
            this.nbLigns = (int)this.numericUpDownNbLignes.Value;
            this.nbCols = (int)this.numericUpDownNbColonnes.Value;
            this.tailleCase = (int)this.numericUpDownTailleCase.Value;
            creerCases();
            // -------------------------------------
        }
        private void creerCases()
        {
            // -------------------------------------
            // Creer les cases
            this.lesCases = new bool[this.nbLigns, this.nbCols];
            this.lesCasesTemp = new bool[this.nbLigns, this.nbCols];
            for (int i = 0; i < this.nbLigns; i++)
            {
                for (int j = 0; j < this.nbCols; j++)
                {
                    this.lesCases[i, j] = false;
                    this.lesCasesTemp[i, j] = false;
                }
            }

            this.panelPlateau.Size = new Size(
                this.nbCols * this.tailleCase + this.nbCols * this.espacementCases + this.espacementCases,
                this.nbLigns * this.tailleCase + this.nbLigns * this.espacementCases + this.espacementCases
                );

            this.leGraph = this.panelPlateau.CreateGraphics();

            dessinerCases();
            // -------------------------------------
        }
        private int nbVoisins(int laLigne, int laColonne)
        {
            // -------------------------------------
            if (this.lesCases != null)
            {
                int count = 0;
                /* [+][+][+]
                 * [+][+][+]
                 * [+][+][+]
                 * */
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        int newLigne = laLigne + i;
                        int newColonne = laColonne + j;

                        if (this.checkBoxSortir.Checked)
                        {
                            // Gère les sortie d'écran
                            if (newLigne < 0) { newLigne = this.nbLigns - 1; }
                            else if (newLigne > this.nbLigns - 1) { newLigne = 0; }

                            if (newColonne < 0) { newColonne = this.nbCols - 1; }
                            else if (newColonne > this.nbCols - 1) { newColonne = 0; }

                            count += this.lesCases[newLigne, newColonne] ? 1 : 0;
                        }
                        else
                        {
                            // Bloque la sortie d'écran
                            if (
                                (newLigne >= 0 && newLigne < this.nbLigns)
                                &&
                                (newColonne >= 0 && newColonne < this.nbCols)
                                )
                            {
                                count += this.lesCases[newLigne, newColonne] ? 1 : 0;
                            }
                        }
                    }
                }
                /* [+][+][+]
                 * [+][-][+]
                 * [+][+][+]
                 * */
                return count - (this.lesCases[laLigne, laColonne] ? 1 : 0);
            }
            else
            {
                return 0;
            }
            // -------------------------------------
        }
        private void nextGeneration()
        {
            // -------------------------------------
            if (this.lesCases != null)
            {
                int x = this.espacementCases;
                int y = this.espacementCases;

                for (int i = 0; i < this.nbLigns; i++)
                {
                    for (int j = 0; j < this.nbCols; j++)
                    {
                        int nb = nbVoisins(i, j);

                        if (nb < 2 || nb > 3)
                        {
                            this.lesCasesTemp[i, j] = false; // Meurt
                            this.leGraph.FillRectangle(
                                this.brushMorte,
                                x, y,
                                this.tailleCase, this.tailleCase
                                );
                        }
                        else if (nb == 2)
                        {
                            this.lesCasesTemp[i, j] = this.lesCases[i, j]; // Survie
                        }
                        else if (nb == 3)
                        {
                            this.lesCasesTemp[i, j] = true; // Nait
                            this.leGraph.FillRectangle(
                                this.brushVivante,
                                x, y,
                                this.tailleCase, this.tailleCase
                                );
                        }

                        x += this.tailleCase + this.espacementCases;
                    }
                    x = this.espacementCases;
                    y += this.tailleCase + this.espacementCases;
                }


                for (int i = 0; i < this.nbLigns; i++)
                {
                    for (int j = 0; j < this.nbCols; j++)
                    {
                        this.lesCases[i, j] = this.lesCasesTemp[i, j];
                    }
                }


            }
            // -------------------------------------
        }
        private void dessinerCases()
        {
            // -------------------------------------
            if (this.lesCases != null)
            {
                int x = this.espacementCases;
                int y = this.espacementCases;

                for (int i = 0; i < this.nbLigns; i++)
                {
                    for (int j = 0; j < this.nbCols; j++)
                    {
                        this.leGraph.FillRectangle(
                            this.lesCases[i, j] ? this.brushVivante : this.brushMorte,
                            x, y,
                            this.tailleCase, this.tailleCase
                            );

                        x += this.tailleCase + this.espacementCases;
                    }
                    x = this.espacementCases;
                    y += this.tailleCase + this.espacementCases;
                }

            }
            // -------------------------------------
        }
        // ====================================================================
    }
}
