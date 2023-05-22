using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliothequeJeu;
namespace TD4
{
    public partial class Form1 : Form
    {

        internal Partie PartieEnCours; // ?PartieEnCours nullable -> pour VS2022
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (nudNbManches.Value % 2 == 0)
            {
            }
            else
            {
                nudNbManches.Value = nudNbManches.Value + 1;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2;
            PartieEnCours = new Partie(lblJoueur1.Text, lblJoueur2.Text, rdoClassique.Checked, Convert.ToByte(nudNbManches.Value), rdoCodif1.Checked);


            frm2 = new Form2();
            frm2.Show(this);
            this.Hide();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoDecod1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdoDecod2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdoCodif1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoDecod1_Click(object sender, EventArgs e)
        {
            rdoCodif2.Checked = true;
        }

        private void rdoDecod2_Click(object sender, EventArgs e)
        {
            rdoCodif1.Checked = true;
        }

        private void rdoCodif1_Click(object sender, EventArgs e)
        {
            rdoDecod2.Checked = true;
        }

        private void rdoCodif2_Click(object sender, EventArgs e)
        {
            rdoDecod1.Checked = true;
        }

        private void grpPartie_Enter(object sender, EventArgs e)
        {

        }

        private void nudNbManches_Leave(object sender, EventArgs e)
        {
            if (nudNbManches.Text == "")
            {

                nudNbManches.Text = nudNbManches.Value.ToString();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {            
            Environment.Exit(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
