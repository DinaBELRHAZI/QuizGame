using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfSharp;

namespace QuizGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Création du pdf
            PdfDocument document = new PdfDocument();
            //You will have to add Page in PDF Document
            PdfPage page = document.AddPage();

            page.Size = PageSize.Letter;
            page.Orientation = PageOrientation.Landscape;

            // XGraphics Object permet de dessiner dans un pdf
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //Font du text
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            String nom = textBox1.Text;
            String prenom = textBox2.Text;

           // Ajout du cadre dans le pdf
            XImage image = XImage.FromFile("cadre3.png");
            gfx.DrawImage(image, 0, 0, page.Width, page.Height);

            // Text à insérer dans le pdf
            gfx.DrawString("CERTIFICAT DE REUSSITE ", new XFont("Garamond", 50, XFontStyle.Regular), XBrushes.Goldenrod, new XRect(10, 80, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString("Ce certificat est décerné à ", new XFont("Garamond", 30, XFontStyle.Italic), XBrushes.Black, new XRect(0, 180, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString(prenom + " " + nom, new XFont("Garamond", 50, XFontStyle.Bold), XBrushes.Goldenrod, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("pour avoir terminé avec succès le quiz de connaissance sur l'archéologie.", new XFont("Garamond", 20, XFontStyle.Regular), XBrushes.Black, new XRect(0, 60, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("2022/2023 ", new XFont("Garamond", 20, XFontStyle.Regular), XBrushes.Black, new XRect(100, 170, page.Width, page.Height), XStringFormats.CenterLeft);


            //Spécification du nom du fichier PDF
            string filename = "Certificat_"+ nom + "_" + prenom +".pdf";
            //Enregistrement du pdf
            document.Save(filename);
            //Ouverture du fichier pdf pour le visualiser
            Process.Start(filename);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
