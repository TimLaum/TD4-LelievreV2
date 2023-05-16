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
                e.Effect = DragDropEffects.Copy;
           
        }

        private void picblue_DragDrop(object sender, DragEventArgs e)
        {
            Image img;
            img = (Image)e.Data.GetData(DataFormats.Bitmap);
            picblue.Image = img;

        }

        private void picdrop1_DragDrop(object sender, DragEventArgs e)
        {
            Image img;
            img = (Image)e.Data.GetData(DataFormats.Bitmap);
            picdrop1.Image = img;
        }

        private void picblue_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
