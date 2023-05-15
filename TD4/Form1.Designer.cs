
namespace TD4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpJoueurs = new System.Windows.Forms.GroupBox();
            this.pnlJ2 = new System.Windows.Forms.Panel();
            this.rdoDecod2 = new System.Windows.Forms.RadioButton();
            this.rdoCodif2 = new System.Windows.Forms.RadioButton();
            this.pnlJ1 = new System.Windows.Forms.Panel();
            this.rdoCodif1 = new System.Windows.Forms.RadioButton();
            this.rdoDecod1 = new System.Windows.Forms.RadioButton();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.lblJoueur1 = new System.Windows.Forms.Label();
            this.grpPartie = new System.Windows.Forms.GroupBox();
            this.nudNbManches = new System.Windows.Forms.NumericUpDown();
            this.rdoDebutant = new System.Windows.Forms.RadioButton();
            this.rdoClassique = new System.Windows.Forms.RadioButton();
            this.lblNbManche = new System.Windows.Forms.Label();
            this.lblNivjeu = new System.Windows.Forms.Label();
            this.btnJouer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpJoueurs.SuspendLayout();
            this.pnlJ2.SuspendLayout();
            this.pnlJ1.SuspendLayout();
            this.grpPartie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbManches)).BeginInit();
            this.SuspendLayout();
            // 
            // grpJoueurs
            // 
            this.grpJoueurs.Controls.Add(this.pnlJ2);
            this.grpJoueurs.Controls.Add(this.pnlJ1);
            this.grpJoueurs.Controls.Add(this.lblJoueur2);
            this.grpJoueurs.Controls.Add(this.lblJoueur1);
            this.grpJoueurs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpJoueurs.Location = new System.Drawing.Point(215, 69);
            this.grpJoueurs.Name = "grpJoueurs";
            this.grpJoueurs.Size = new System.Drawing.Size(347, 124);
            this.grpJoueurs.TabIndex = 0;
            this.grpJoueurs.TabStop = false;
            this.grpJoueurs.Text = "Les joueurs";
            this.grpJoueurs.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pnlJ2
            // 
            this.pnlJ2.Controls.Add(this.rdoDecod2);
            this.pnlJ2.Controls.Add(this.rdoCodif2);
            this.pnlJ2.Location = new System.Drawing.Point(101, 77);
            this.pnlJ2.Name = "pnlJ2";
            this.pnlJ2.Size = new System.Drawing.Size(206, 28);
            this.pnlJ2.TabIndex = 7;
            this.pnlJ2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rdoDecod2
            // 
            this.rdoDecod2.AutoSize = true;
            this.rdoDecod2.Checked = true;
            this.rdoDecod2.Location = new System.Drawing.Point(122, 6);
            this.rdoDecod2.Name = "rdoDecod2";
            this.rdoDecod2.Size = new System.Drawing.Size(85, 18);
            this.rdoDecod2.TabIndex = 5;
            this.rdoDecod2.TabStop = true;
            this.rdoDecod2.Text = "Décodeur";
            this.rdoDecod2.UseVisualStyleBackColor = true;
            this.rdoDecod2.CheckedChanged += new System.EventHandler(this.rdoDecod2_CheckedChanged);
            this.rdoDecod2.Click += new System.EventHandler(this.rdoDecod2_Click);
            // 
            // rdoCodif2
            // 
            this.rdoCodif2.AutoSize = true;
            this.rdoCodif2.Location = new System.Drawing.Point(0, 6);
            this.rdoCodif2.Name = "rdoCodif2";
            this.rdoCodif2.Size = new System.Drawing.Size(100, 18);
            this.rdoCodif2.TabIndex = 3;
            this.rdoCodif2.Text = "Codificateur";
            this.rdoCodif2.UseVisualStyleBackColor = true;
            this.rdoCodif2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.rdoCodif2.Click += new System.EventHandler(this.rdoCodif2_Click);
            // 
            // pnlJ1
            // 
            this.pnlJ1.Controls.Add(this.rdoCodif1);
            this.pnlJ1.Controls.Add(this.rdoDecod1);
            this.pnlJ1.Location = new System.Drawing.Point(101, 34);
            this.pnlJ1.Name = "pnlJ1";
            this.pnlJ1.Size = new System.Drawing.Size(207, 28);
            this.pnlJ1.TabIndex = 6;
            // 
            // rdoCodif1
            // 
            this.rdoCodif1.AutoSize = true;
            this.rdoCodif1.Checked = true;
            this.rdoCodif1.Location = new System.Drawing.Point(0, 0);
            this.rdoCodif1.Name = "rdoCodif1";
            this.rdoCodif1.Size = new System.Drawing.Size(100, 18);
            this.rdoCodif1.TabIndex = 2;
            this.rdoCodif1.TabStop = true;
            this.rdoCodif1.Text = "Codificateur";
            this.rdoCodif1.UseVisualStyleBackColor = true;
            this.rdoCodif1.CheckedChanged += new System.EventHandler(this.rdoCodif1_CheckedChanged);
            this.rdoCodif1.Click += new System.EventHandler(this.rdoCodif1_Click);
            // 
            // rdoDecod1
            // 
            this.rdoDecod1.AutoSize = true;
            this.rdoDecod1.Location = new System.Drawing.Point(122, 0);
            this.rdoDecod1.Name = "rdoDecod1";
            this.rdoDecod1.Size = new System.Drawing.Size(85, 18);
            this.rdoDecod1.TabIndex = 4;
            this.rdoDecod1.Text = "Décodeur";
            this.rdoDecod1.UseVisualStyleBackColor = true;
            this.rdoDecod1.CheckedChanged += new System.EventHandler(this.rdoDecod1_CheckedChanged);
            this.rdoDecod1.Click += new System.EventHandler(this.rdoDecod1_Click);
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.AutoSize = true;
            this.lblJoueur2.Location = new System.Drawing.Point(17, 90);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(61, 14);
            this.lblJoueur2.TabIndex = 1;
            this.lblJoueur2.Text = "Joueur 2";
            this.lblJoueur2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblJoueur1
            // 
            this.lblJoueur1.AutoSize = true;
            this.lblJoueur1.Location = new System.Drawing.Point(17, 34);
            this.lblJoueur1.Name = "lblJoueur1";
            this.lblJoueur1.Size = new System.Drawing.Size(61, 14);
            this.lblJoueur1.TabIndex = 0;
            this.lblJoueur1.Text = "Joueur 1";
            // 
            // grpPartie
            // 
            this.grpPartie.Controls.Add(this.nudNbManches);
            this.grpPartie.Controls.Add(this.rdoDebutant);
            this.grpPartie.Controls.Add(this.rdoClassique);
            this.grpPartie.Controls.Add(this.lblNbManche);
            this.grpPartie.Controls.Add(this.lblNivjeu);
            this.grpPartie.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpPartie.Location = new System.Drawing.Point(215, 224);
            this.grpPartie.Name = "grpPartie";
            this.grpPartie.Size = new System.Drawing.Size(347, 125);
            this.grpPartie.TabIndex = 1;
            this.grpPartie.TabStop = false;
            this.grpPartie.Text = "La partie";
            this.grpPartie.Enter += new System.EventHandler(this.grpPartie_Enter);
            // 
            // nudNbManches
            // 
            this.nudNbManches.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNbManches.Location = new System.Drawing.Point(223, 82);
            this.nudNbManches.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNbManches.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNbManches.Name = "nudNbManches";
            this.nudNbManches.Size = new System.Drawing.Size(74, 22);
            this.nudNbManches.TabIndex = 8;
            this.nudNbManches.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNbManches.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nudNbManches.Leave += new System.EventHandler(this.nudNbManches_Leave);
            // 
            // rdoDebutant
            // 
            this.rdoDebutant.AutoSize = true;
            this.rdoDebutant.Location = new System.Drawing.Point(223, 37);
            this.rdoDebutant.Name = "rdoDebutant";
            this.rdoDebutant.Size = new System.Drawing.Size(84, 18);
            this.rdoDebutant.TabIndex = 7;
            this.rdoDebutant.TabStop = true;
            this.rdoDebutant.Text = "Débutant";
            this.rdoDebutant.UseVisualStyleBackColor = true;
            // 
            // rdoClassique
            // 
            this.rdoClassique.AutoSize = true;
            this.rdoClassique.Checked = true;
            this.rdoClassique.Location = new System.Drawing.Point(116, 35);
            this.rdoClassique.Name = "rdoClassique";
            this.rdoClassique.Size = new System.Drawing.Size(86, 18);
            this.rdoClassique.TabIndex = 6;
            this.rdoClassique.TabStop = true;
            this.rdoClassique.Text = "Classique";
            this.rdoClassique.UseVisualStyleBackColor = true;
            this.rdoClassique.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // lblNbManche
            // 
            this.lblNbManche.AutoSize = true;
            this.lblNbManche.Location = new System.Drawing.Point(17, 84);
            this.lblNbManche.Name = "lblNbManche";
            this.lblNbManche.Size = new System.Drawing.Size(136, 14);
            this.lblNbManche.TabIndex = 1;
            this.lblNbManche.Text = "Nombre de manches";
            // 
            // lblNivjeu
            // 
            this.lblNivjeu.AutoSize = true;
            this.lblNivjeu.Location = new System.Drawing.Point(17, 39);
            this.lblNivjeu.Name = "lblNivjeu";
            this.lblNivjeu.Size = new System.Drawing.Size(94, 14);
            this.lblNivjeu.TabIndex = 0;
            this.lblNivjeu.Text = "Niveau de jeu";
            this.lblNivjeu.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJouer.Location = new System.Drawing.Point(215, 386);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(347, 34);
            this.btnJouer.TabIndex = 2;
            this.btnJouer.Text = "Jouer !";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(316, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Paramétrage du jeu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.grpPartie);
            this.Controls.Add(this.grpJoueurs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpJoueurs.ResumeLayout(false);
            this.grpJoueurs.PerformLayout();
            this.pnlJ2.ResumeLayout(false);
            this.pnlJ2.PerformLayout();
            this.pnlJ1.ResumeLayout(false);
            this.pnlJ1.PerformLayout();
            this.grpPartie.ResumeLayout(false);
            this.grpPartie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbManches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpJoueurs;
        private System.Windows.Forms.GroupBox grpPartie;
        private System.Windows.Forms.Label lblJoueur2;
        private System.Windows.Forms.Label lblJoueur1;
        private System.Windows.Forms.RadioButton rdoDecod2;
        private System.Windows.Forms.RadioButton rdoDecod1;
        private System.Windows.Forms.RadioButton rdoCodif2;
        private System.Windows.Forms.RadioButton rdoCodif1;
        private System.Windows.Forms.Label lblNivjeu;
        private System.Windows.Forms.RadioButton rdoDebutant;
        private System.Windows.Forms.RadioButton rdoClassique;
        private System.Windows.Forms.Label lblNbManche;
        private System.Windows.Forms.NumericUpDown nudNbManches;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlJ2;
        private System.Windows.Forms.Panel pnlJ1;
    }
}

