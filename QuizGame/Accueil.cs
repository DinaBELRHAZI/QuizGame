using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Accueil : Form
    {
        public MongoClient client;
        public List<quiz> ListLeaders = new List<quiz>();


        public Accueil()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Quiz d'entraînement
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bon entrainement !");

           
            quiz_entrainement train = new quiz_entrainement();
            train.ShowDialog();
        }

        // Quiz chronométré
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention ! Le chrono va vite se déclencher.");
            
            quiz_chronometre quizchrono = new quiz_chronometre();
            quizchrono.ShowDialog();

        }

        // Quiz avec obtention du certificat
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonne chance !");

            Form1 exam = new Form1();
            exam.ShowDialog();
        }

        
    }
}
