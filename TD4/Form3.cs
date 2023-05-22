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

        }


        private void picdrop1_DragDrop(object sender, DragEventArgs e)
        {
            picdrop1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            picdrop1.AllowDrop = true;
            picdrop2.AllowDrop = true;
            picdrop3.AllowDrop = true;
            picdrop4.AllowDrop = true;
        }

        private void pics_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox img = (PictureBox)sender;

            if (e.Button == MouseButtons.Left)
            {
                this.DoDragDrop(img.Image, DragDropEffects.Copy);
            }
        }

        private void picdrops_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picdrops_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            img.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
    }
}
