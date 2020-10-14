namespace Jeu_de_la_vie
{
    partial class formJeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJeu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.timerDemarrer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownNbLignes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownNbColonnes = new System.Windows.Forms.NumericUpDown();
            this.buttonDemarrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonReinit = new System.Windows.Forms.Button();
            this.numericUpDownTailleCase = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.numericUpDownVitesse = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerer = new System.Windows.Forms.Button();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxSortir = new System.Windows.Forms.CheckBox();
            this.panelPlateau = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUnFichierjdlvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderDansUnFichierjdlvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbLignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbColonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTailleCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVitesse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 10);
            this.panel1.TabIndex = 0;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreer.Location = new System.Drawing.Point(30, 280);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(150, 35);
            this.buttonCreer.TabIndex = 2;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // timerDemarrer
            // 
            this.timerDemarrer.Interval = 1;
            this.timerDemarrer.Tick += new System.EventHandler(this.timerDemarrer_Tick);
            // 
            // numericUpDownNbLignes
            // 
            this.numericUpDownNbLignes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNbLignes.Location = new System.Drawing.Point(30, 80);
            this.numericUpDownNbLignes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNbLignes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNbLignes.Name = "numericUpDownNbLignes";
            this.numericUpDownNbLignes.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownNbLignes.TabIndex = 3;
            this.numericUpDownNbLignes.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownNbLignes.ValueChanged += new System.EventHandler(this.numericUpDownNbLignes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de colonnes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de lignes";
            // 
            // numericUpDownNbColonnes
            // 
            this.numericUpDownNbColonnes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNbColonnes.Location = new System.Drawing.Point(30, 155);
            this.numericUpDownNbColonnes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNbColonnes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNbColonnes.Name = "numericUpDownNbColonnes";
            this.numericUpDownNbColonnes.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownNbColonnes.TabIndex = 6;
            this.numericUpDownNbColonnes.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownNbColonnes.ValueChanged += new System.EventHandler(this.numericUpDownNbColonnes_ValueChanged);
            // 
            // buttonDemarrer
            // 
            this.buttonDemarrer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemarrer.Location = new System.Drawing.Point(30, 505);
            this.buttonDemarrer.Name = "buttonDemarrer";
            this.buttonDemarrer.Size = new System.Drawing.Size(150, 35);
            this.buttonDemarrer.TabIndex = 7;
            this.buttonDemarrer.Text = "Démarrer";
            this.buttonDemarrer.UseVisualStyleBackColor = true;
            this.buttonDemarrer.Click += new System.EventHandler(this.buttonDemarrer_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(30, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 2);
            this.label3.TabIndex = 8;
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.Location = new System.Drawing.Point(30, 555);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(150, 35);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonReinit
            // 
            this.buttonReinit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReinit.Location = new System.Drawing.Point(30, 605);
            this.buttonReinit.Name = "buttonReinit";
            this.buttonReinit.Size = new System.Drawing.Size(150, 35);
            this.buttonReinit.TabIndex = 10;
            this.buttonReinit.Text = "Réinitialiser";
            this.buttonReinit.UseVisualStyleBackColor = true;
            this.buttonReinit.Click += new System.EventHandler(this.buttonReinit_Click);
            // 
            // numericUpDownTailleCase
            // 
            this.numericUpDownTailleCase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTailleCase.Location = new System.Drawing.Point(30, 230);
            this.numericUpDownTailleCase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTailleCase.Name = "numericUpDownTailleCase";
            this.numericUpDownTailleCase.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownTailleCase.TabIndex = 12;
            this.numericUpDownTailleCase.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownTailleCase.ValueChanged += new System.EventHandler(this.numericUpDownTailleCase_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Taille des cases";
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.Location = new System.Drawing.Point(30, 655);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(150, 35);
            this.buttonSuivant.TabIndex = 13;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // numericUpDownVitesse
            // 
            this.numericUpDownVitesse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownVitesse.Location = new System.Drawing.Point(30, 455);
            this.numericUpDownVitesse.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownVitesse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVitesse.Name = "numericUpDownVitesse";
            this.numericUpDownVitesse.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownVitesse.TabIndex = 15;
            this.numericUpDownVitesse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVitesse.ValueChanged += new System.EventHandler(this.numericUpDownVitesse_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vitesse";
            // 
            // buttonGenerer
            // 
            this.buttonGenerer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerer.Location = new System.Drawing.Point(30, 330);
            this.buttonGenerer.Name = "buttonGenerer";
            this.buttonGenerer.Size = new System.Drawing.Size(150, 35);
            this.buttonGenerer.TabIndex = 16;
            this.buttonGenerer.Text = "Générer";
            this.buttonGenerer.UseVisualStyleBackColor = true;
            this.buttonGenerer.Click += new System.EventHandler(this.buttonGenerer_Click);
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGitHub.Location = new System.Drawing.Point(1075, 50);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(95, 21);
            this.linkLabelGitHub.TabIndex = 17;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "Mon GitHub";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(30, 720);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 2);
            this.label6.TabIndex = 18;
            // 
            // checkBoxSortir
            // 
            this.checkBoxSortir.Checked = true;
            this.checkBoxSortir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSortir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSortir.Location = new System.Drawing.Point(30, 735);
            this.checkBoxSortir.Name = "checkBoxSortir";
            this.checkBoxSortir.Size = new System.Drawing.Size(150, 62);
            this.checkBoxSortir.TabIndex = 19;
            this.checkBoxSortir.Text = "La sortie renvoie au coté opposé";
            this.checkBoxSortir.UseVisualStyleBackColor = true;
            // 
            // panelPlateau
            // 
            this.panelPlateau.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelPlateau.Location = new System.Drawing.Point(210, 80);
            this.panelPlateau.Name = "panelPlateau";
            this.panelPlateau.Size = new System.Drawing.Size(940, 700);
            this.panelPlateau.TabIndex = 20;
            this.panelPlateau.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlateau_Paint);
            this.panelPlateau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPlateau_MouseDown);
            this.panelPlateau.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPlateau_MouseMove);
            this.panelPlateau.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPlateau_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 29);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUnFichierjdlvToolStripMenuItem,
            this.sauvegarderDansUnFichierjdlvToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirUnFichierjdlvToolStripMenuItem
            // 
            this.ouvrirUnFichierjdlvToolStripMenuItem.Name = "ouvrirUnFichierjdlvToolStripMenuItem";
            this.ouvrirUnFichierjdlvToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.ouvrirUnFichierjdlvToolStripMenuItem.Text = "Ouvrir un fichier .jdlv";
            this.ouvrirUnFichierjdlvToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUnFichierjdlvToolStripMenuItem_Click);
            // 
            // sauvegarderDansUnFichierjdlvToolStripMenuItem
            // 
            this.sauvegarderDansUnFichierjdlvToolStripMenuItem.Name = "sauvegarderDansUnFichierjdlvToolStripMenuItem";
            this.sauvegarderDansUnFichierjdlvToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.sauvegarderDansUnFichierjdlvToolStripMenuItem.Text = "Sauvegarder dans un fichier .jdlv";
            this.sauvegarderDansUnFichierjdlvToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderDansUnFichierjdlvToolStripMenuItem_Click);
            // 
            // formJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.panelPlateau);
            this.Controls.Add(this.checkBoxSortir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.buttonGenerer);
            this.Controls.Add(this.numericUpDownVitesse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.numericUpDownTailleCase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonReinit);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDemarrer);
            this.Controls.Add(this.numericUpDownNbColonnes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNbLignes);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formJeu";
            this.Text = "Jeu de la vie - Par BUSTOS Thibault (TheRake66) - Version 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbLignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbColonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTailleCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVitesse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Timer timerDemarrer;
        private System.Windows.Forms.NumericUpDown numericUpDownNbLignes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownNbColonnes;
        private System.Windows.Forms.Button buttonDemarrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonReinit;
        private System.Windows.Forms.NumericUpDown numericUpDownTailleCase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.NumericUpDown numericUpDownVitesse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerer;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxSortir;
        private System.Windows.Forms.Panel panelPlateau;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUnFichierjdlvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderDansUnFichierjdlvToolStripMenuItem;
    }
}

