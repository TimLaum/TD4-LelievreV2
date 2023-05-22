using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TD4
{
    public partial class Form3 : Form
    {
        public static readonly string Bitmap;
        public Form3()
        {
            InitializeComponent();
            
        }

        private void picvio_Click(object sender, EventArgs e)
        {

        }

        private void picdrop1_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void picblue_DragDrop(object sender, DragEventArgs e)
        {
            Image img;
            img = (Image)e.Data.GetData(DataFormats.Bitmap);
            picblue.Image = img;

        }

        private void picdrop1_DragDrop(object sender, DragEventArgs e)
        {
            picdrop1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picblue_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            
        }


        private void picvio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picvio.DoDragDrop(picvio.Image, DragDropEffects.Copy);
            }
        }

        private void picora_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picora.DoDragDrop(picvio.Image, DragDropEffects.Copy);
            }
        }

        private void picred_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picred.DoDragDrop(picvio.Image, DragDropEffects.Copy);
            }
        }

        private void picvert_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picvert.DoDragDrop(picvio.Image, DragDropEffects.Copy);
            }
        }

        private void picyel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picyel.DoDragDrop(picvio.Image, DragDropEffects.Copy);
            }
        }

        private void picblue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picblue.DoDragDrop(picvio.Image, DragDropEffects.Copy);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            picdrop1.AllowDrop = true;
        }
    }
}
