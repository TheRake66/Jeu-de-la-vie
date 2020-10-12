using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_la_vie
{
    public partial class formJeu : Form
    {
        // -------------------------------------
        Panel[][] lesCases;
        int xOrigin = 250;
        int yOrigin = 60;
        // -------------------------------------



        // ====================================================================
        public formJeu()
        {
            // -------------------------------------
            InitializeComponent();
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
        private void buttonGenerer_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            if (this.lesCases != null)
            {
                // Aleatoire les cases
                Random unAlea = new Random();
                foreach (Panel[] uneLigne in this.lesCases)
                {
                    foreach (Panel uneCase in uneLigne)
                    {
                        uneCase.BackColor = unAlea.Next(0, 2) == 0 ? Color.White : Color.Black;
                    }
                }
            }
            // -------------------------------------
        }
        private void buttonCreer_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            creerCase();
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
                foreach (Panel[] uneLigne in this.lesCases)
                {
                    foreach (Panel uneCase in uneLigne)
                    {
                        uneCase.BackColor = Color.White;
                    }
                }
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
        private void creerCase()
        {
            // -------------------------------------
            // Efface les cases
            if (this.lesCases != null)
            {
                foreach (Panel[] uneLigne in this.lesCases)
                {
                    foreach (Panel uneCase in uneLigne)
                    {
                        uneCase.Dispose();
                    }
                }
            }

            // Creer des variables pour retrecir le code
            int nbLigns = (int)this.numericUpDownNbLignes.Value;
            int nbCols = (int)this.numericUpDownNbColonnes.Value;
            int tailleCase = (int)this.numericUpDownTailleCase.Value;

            // Erreur de creation de handle de fenetre
            if (nbLigns * nbCols >= 10000)
            {
                MessageBox.Show("Impossible de créer plus ou 10 000 cases !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Creer les cases
                this.lesCases = new Panel[nbLigns][];
                for (int i = 0; i < nbLigns; i++)
                {
                    this.lesCases[i] = new Panel[nbCols];
                    for (int j = 0; j < nbCols; j++)
                    {
                        Panel uneCase = new Panel();
                        uneCase.BorderStyle = BorderStyle.FixedSingle;
                        uneCase.BackColor = Color.White;
                        uneCase.Size = new Size(tailleCase, tailleCase);
                        uneCase.Location = new Point(xOrigin + j * tailleCase, yOrigin + i * tailleCase);
                        uneCase.Click += new EventHandler((e, s) =>
                        {
                            uneCase.BackColor = uneCase.BackColor == Color.Black ? Color.White : Color.Black;
                        });

                        this.lesCases[i][j] = uneCase;
                    }
                }

                // Ajoute les cases à la fenetre
                foreach (Panel[] uneLigne in this.lesCases)
                {
                    this.Controls.AddRange(uneLigne);
                }
            }
            // -------------------------------------
        }

        private int nbVoisins(int laLigne, int laColonne)
        {
            // -------------------------------------
            if (this.lesCases != null)
            {
                int count = 0;
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        int newLigne = laLigne + i;
                        int newColonne = laColonne + j;

                        if (this.checkBoxSortir.Checked)
                        {
                            // Gère les sortie d'écran
                            if (newLigne < 0) { newLigne = this.lesCases.Length - 1; }
                            else if (newLigne > this.lesCases.Length - 1) { newLigne = 0; }

                            if (newColonne < 0) { newColonne = this.lesCases[0].Length - 1; }
                            else if (newColonne > this.lesCases[0].Length - 1) { newColonne = 0; }

                            count += this.lesCases[newLigne][newColonne].BackColor == Color.Black ? 1 : 0;
                        }
                        else
                        {
                            // Bloque la sortie d'écran
                            if (
                                (newLigne >= 0 && newLigne < this.lesCases.Length)
                                &&
                                (newColonne >= 0 && newColonne < this.lesCases[0].Length)
                                )
                            {
                                count += this.lesCases[newLigne][newColonne].BackColor == Color.Black ? 1 : 0;
                            }
                        }


                    }
                }
                return count - (this.lesCases[laLigne][laColonne].BackColor == Color.Black ? 1 : 0);
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
                Color[][] newColor = new Color[this.lesCases.Length][];
                for (int i = 0; i < this.lesCases.Length; i++)
                {
                    newColor[i] = new Color[this.lesCases[i].Length];
                    for (int j = 0; j < this.lesCases[i].Length; j++)
                    {

                        int nb = nbVoisins(i, j);

                        if (nb < 2 || nb > 3)
                        {
                            newColor[i][j] = Color.White;
                        }
                        else if (nb == 2)
                        {
                            newColor[i][j] = this.lesCases[i][j].BackColor;
                        }
                        else if (nb == 3)
                        {
                            newColor[i][j] = Color.Black;
                        }

                    }
                }

                for (int i = 0; i < this.lesCases.Length; i++)
                {
                    for (int j = 0; j < this.lesCases[i].Length; j++)
                    {
                        this.lesCases[i][j].BackColor = newColor[i][j];
                    }
                }
            }
            // -------------------------------------
        }
        // ====================================================================
    }
}
