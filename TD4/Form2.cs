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
        private bool exit;
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
            exit = false;
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            exit = true;
            frmParam = (Form1)this.Owner;
            lblNiveau.Text = frmParam.PartieEnCours.modeJeu;
            lblNbManche.Text = $"Manche {frmParam.PartieEnCours.mancheEnCours} sur {frmParam.PartieEnCours.nbManches}";
            lblJ1Role.Text = frmParam.PartieEnCours.roleJ1;
            lblJ1Point.Text = $"{frmParam.PartieEnCours.pointsJ1} points";
            lblJ2Role.Text = frmParam.PartieEnCours.roleJ2;
            lblJ2Point.Text = $"{frmParam.PartieEnCours.pointsJ2} points";
        }

        private void btnnxt_Click(object sender, EventArgs e)
        {
            Form3 frm3;
            frm3 = new Form3();
            this.Hide();
            frm3.Show(this);
            exit = false;
            
            
        }

        private void picdrops_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private void pics_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox img = (PictureBox)sender;

            if (e.Button == MouseButtons.Left)
            {
                this.DoDragDrop(img.Image, DragDropEffects.Copy);
            }
        }

        private void picdrops_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            img.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(exit)
            Environment.Exit(1);
        }
    }
}
