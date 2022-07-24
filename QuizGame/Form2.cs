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
            //Create PDF Document
            PdfDocument document = new PdfDocument();
            //You will have to add Page in PDF Document
            PdfPage page = document.AddPage();

            page.Size = PageSize.Letter;
            page.Orientation = PageOrientation.Landscape;

            //For drawing in PDF Page you will nedd XGraphics Object
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //For Text you will have to define font to be used
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            String nom = textBox1.Text;
            String prenom = textBox2.Text;

            //Finally use XGraphics & font object to draw text in PDF Page
            /*gfx.DrawString(
                "CERTIFICAT DE REUSSITE "
                + Environment.NewLine + Environment.NewLine
                + "décerné à "
                + Environment.NewLine + Environment.NewLine
                + prenom + " " + nom
                , 
                font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), 
                XStringFormats.Center
            );*/



            XImage image = XImage.FromFile("encadrement.png");

            
            gfx.DrawImage(image, 0, 0, page.Width, page.Height);

            /*gfx.DrawString("CERTIFICAT DE REUSSITE " , new XFont("Garamond", 12, XFontStyle.Regular), XBrushes.Firebrick, 100, 670, XStringFormats.TopCenter);
            gfx.DrawString("décerné à ", new XFont("Garamond", 10, XFontStyle.Italic), XBrushes.DodgerBlue, 100, 685, XStringFormats.Center);
            gfx.DrawString(prenom + " " + nom, new XFont("Garamond", 10, XFontStyle.Bold), XBrushes.DodgerBlue, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("2022/2023 ", new XFont("Garamond", 10, XFontStyle.Regular), XBrushes.DodgerBlue, new XRect(0, 0, page.Width, page.Height), XStringFormats.BottomLeft);*/


            gfx.DrawString("CERTIFICAT DE REUSSITE ", new XFont("Garamond", 50, XFontStyle.Regular), XBrushes.Goldenrod, new XRect(10, 80, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString("Ceci est remis à ", new XFont("Garamond", 30, XFontStyle.Italic), XBrushes.Black, new XRect(0, 180, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString(prenom + " " + nom, new XFont("Garamond", 50, XFontStyle.Bold), XBrushes.Goldenrod, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("pour avoir terminé avec succès le quiz de connaissance sur l'archéologie.", new XFont("Garamond", 20, XFontStyle.Regular), XBrushes.Black, new XRect(0, 60, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("2022/2023 ", new XFont("Garamond", 20, XFontStyle.Regular), XBrushes.Black, new XRect(60, 270, page.Width, page.Height), XStringFormats.CenterLeft);


            //Specify file name of the PDF file
            string filename = "Certificat"+ nom + "_" + prenom +".pdf";
            //Save PDF File
            document.Save(filename);
            //Load PDF File for viewing
            Process.Start(filename);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
