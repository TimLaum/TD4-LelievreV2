using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TD4
{
    public partial class Form2 : Form
    {
        private Form1 frmParam;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRetourForm1_Click(object sender, EventArgs e)
        {
            Form1 frm1;
            frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            frmParam = (Form1)this.Owner;
            lblNiveau.Text = frmParam.PartieEnCours.modeJeu;
            lblNbManche.Text = $"Manche {frmParam.PartieEnCours.mancheEnCours} sur {frmParam.PartieEnCours.nbManches}";
            lblJ1Role.Text = frmParam.PartieEnCours.roleJ1;
            lblJ1Point.Text = $"{frmParam.PartieEnCours.pointsJ1} points";
            lblJ2Role.Text = frmParam.PartieEnCours.roleJ2;
            lblJ2Point.Text = $"{frmParam.PartieEnCours.pointsJ2} points";
        }
    }
}
