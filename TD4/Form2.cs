using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BibliothequeJeu;
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
            picdrop1.AllowDrop = true;
            picdrop2.AllowDrop = true;
            picdrop3.AllowDrop = true;
            picdrop4.AllowDrop = true;
            picT11.AllowDrop = true;
            picT12.AllowDrop = true;
            picT13.AllowDrop = true;
            picT14.AllowDrop = true;
            
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

        byte ligne = 1;

        private void btnTentaValide_Click(object sender, EventArgs e)
        {
            PictureBox tenta1= ((PictureBox)pnlTenta.Controls[$"picT{ligne}1"]);
            PictureBox tenta2 = ((PictureBox)pnlTenta.Controls[$"picT{ligne}2"]);
            PictureBox tenta3 = ((PictureBox)pnlTenta.Controls[$"picT{ligne}3"]);
            PictureBox tenta4 = ((PictureBox)pnlTenta.Controls[$"picT{ligne}4"]);
            
            ligne++;
            
            PictureBox maNouvellePictureBox; //déclaration d'un nouvel objet picturebox
            int nbPicDansPanel = pnlTenta.Controls.Count; // nombre de picturebox actuel dans le panel

            // suspension de la logique d'affichage du panel
            pnlTenta.SuspendLayout();

            // instanciation et configuration de la nouvelle picturebox
            // sinon, on prend récupère la localisation X de la dernière créée et on ajoute 50 (hauteur d'1 picturebox + 10 à sa localisation Y 
            if(tenta1.Image != null || tenta2.Image != null || tenta3.Image != null || tenta4.Image != null)
            {

                for(int i = 1; i <5; i++)
                  {
                        maNouvellePictureBox = new PictureBox();
                        maNouvellePictureBox.Name = $"picM{ligne}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                        maNouvellePictureBox.Size = new Size(15, 15); //définition de la taille 
                        maNouvellePictureBox.BorderStyle = BorderStyle.FixedSingle; // définition du type de bordure
                        int x = pnlTenta.Controls[$"picM{ligne-1}{i}"].Location.X;
                        int y = pnlTenta.Controls[$"picM{ligne - 1}{i}"].Location.Y + 40 + 10;
                        maNouvellePictureBox.Location = new Point(x, y);
                        pnlTenta.Controls.Add(maNouvellePictureBox);
                }
                for (int i = 1; i < 5; i++)
                {
                    maNouvellePictureBox = new PictureBox();
                    maNouvellePictureBox.Name = $"picT{ligne}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                    maNouvellePictureBox.Size = new Size(40, 40); //définition de la taille 
                    maNouvellePictureBox.BorderStyle = BorderStyle.FixedSingle; // définition du type de bordure
                    int x = pnlTenta.Controls[$"picT{ligne - 1}{i}"].Location.X;
                    int y = pnlTenta.Controls[$"picT{ligne - 1}{i}"].Location.Y + 40 + 10;
                    maNouvellePictureBox.Location = new Point(x, y);
                    pnlTenta.Controls.Add(maNouvellePictureBox);
                
                }
            }

           

        }

        private void btnValideDecode_Click(object sender, EventArgs e)
        {
            if(picdrop1.Image != null && picdrop2.Image != null && picdrop3.Image != null && picdrop4.Image != null)
            {

                DecodeTenta = new Tentative();
            }
        }
    }
}
