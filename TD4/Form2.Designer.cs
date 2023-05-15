
namespace TD4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRetourForm1 = new System.Windows.Forms.Button();
            this.grpJoueurs = new System.Windows.Forms.GroupBox();
            this.lblNbManche = new System.Windows.Forms.Label();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJ1Point = new System.Windows.Forms.Label();
            this.lblJ1Role = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblJ2Point = new System.Windows.Forms.Label();
            this.lblJ2Role = new System.Windows.Forms.Label();
            this.grpJoueurs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetourForm1
            // 
            this.btnRetourForm1.BackColor = System.Drawing.Color.LightGray;
            this.btnRetourForm1.Location = new System.Drawing.Point(24, 410);
            this.btnRetourForm1.Name = "btnRetourForm1";
            this.btnRetourForm1.Size = new System.Drawing.Size(88, 28);
            this.btnRetourForm1.TabIndex = 1;
            this.btnRetourForm1.Text = "Retour";
            this.btnRetourForm1.UseVisualStyleBackColor = false;
            this.btnRetourForm1.Click += new System.EventHandler(this.btnRetourForm1_Click);
            // 
            // grpJoueurs
            // 
            this.grpJoueurs.Controls.Add(this.lblNbManche);
            this.grpJoueurs.Controls.Add(this.lblNiveau);
            this.grpJoueurs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpJoueurs.Location = new System.Drawing.Point(24, 12);
            this.grpJoueurs.Name = "grpJoueurs";
            this.grpJoueurs.Size = new System.Drawing.Size(263, 102);
            this.grpJoueurs.TabIndex = 3;
            this.grpJoueurs.TabStop = false;
            this.grpJoueurs.Text = "La partie";
            // 
            // lblNbManche
            // 
            this.lblNbManche.AutoSize = true;
            this.lblNbManche.Location = new System.Drawing.Point(6, 80);
            this.lblNbManche.Name = "lblNbManche";
            this.lblNbManche.Size = new System.Drawing.Size(135, 14);
            this.lblNbManche.TabIndex = 4;
            this.lblNbManche.Text = "Nombre de Manches";
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Location = new System.Drawing.Point(6, 32);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(60, 14);
            this.lblNiveau.TabIndex = 3;
            this.lblNiveau.Text = "Difficulté";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblJ1Point);
            this.groupBox1.Controls.Add(this.lblJ1Role);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(24, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joueur 1";
            // 
            // lblJ1Point
            // 
            this.lblJ1Point.AutoSize = true;
            this.lblJ1Point.Location = new System.Drawing.Point(6, 80);
            this.lblJ1Point.Name = "lblJ1Point";
            this.lblJ1Point.Size = new System.Drawing.Size(46, 14);
            this.lblJ1Point.TabIndex = 4;
            this.lblJ1Point.Text = "Points";
            // 
            // lblJ1Role
            // 
            this.lblJ1Role.AutoSize = true;
            this.lblJ1Role.Location = new System.Drawing.Point(6, 32);
            this.lblJ1Role.Name = "lblJ1Role";
            this.lblJ1Role.Size = new System.Drawing.Size(34, 14);
            this.lblJ1Role.TabIndex = 3;
            this.lblJ1Role.Text = "Rôle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblJ2Point);
            this.groupBox2.Controls.Add(this.lblJ2Role);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(24, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 104);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Joueur 2";
            // 
            // lblJ2Point
            // 
            this.lblJ2Point.AutoSize = true;
            this.lblJ2Point.Location = new System.Drawing.Point(6, 80);
            this.lblJ2Point.Name = "lblJ2Point";
            this.lblJ2Point.Size = new System.Drawing.Size(46, 14);
            this.lblJ2Point.TabIndex = 4;
            this.lblJ2Point.Text = "Points";
            // 
            // lblJ2Role
            // 
            this.lblJ2Role.AutoSize = true;
            this.lblJ2Role.Location = new System.Drawing.Point(6, 32);
            this.lblJ2Role.Name = "lblJ2Role";
            this.lblJ2Role.Size = new System.Drawing.Size(34, 14);
            this.lblJ2Role.TabIndex = 3;
            this.lblJ2Role.Text = "Rôle";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpJoueurs);
            this.Controls.Add(this.btnRetourForm1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonjour";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpJoueurs.ResumeLayout(false);
            this.grpJoueurs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRetourForm1;
        private System.Windows.Forms.GroupBox grpJoueurs;
        private System.Windows.Forms.Label lblNbManche;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJ1Point;
        private System.Windows.Forms.Label lblJ1Role;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblJ2Point;
        private System.Windows.Forms.Label lblJ2Role;
    }
}