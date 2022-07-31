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

           // listBox1_SelectedIndexChanged();
        }

        /*private void listBox1_SelectedIndexChanged()
        {
            MessageBox.Show("Bonne chance !");
            //connect to mongodb 
            client = new MongoClient(
            "mongodb://localhost:27017");

            var database = client.GetDatabase("archeo");

            var collectionTest = database.GetCollection<BsonDocument>("quiz_archeo");

            var documents = collectionTest.Find(new BsonDocument()).ToList();

            foreach (BsonDocument doc in documents)
            {
                //MessageBox.Show(doc.ToString());
                MessageBox.Show(doc[1].ToString()+ Environment.NewLine + doc[2].ToString() + Environment.NewLine+ doc[3].ToString() + Environment.NewLine+ doc[4].ToString());


                //var leadertemp = new quiz(doc[1].ToString(), doc[2].ToString(), doc[3].ToString(), doc[4].ToString());
               
                
            }



        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Quiz d'entraînement
        private void button1_Click(object sender, EventArgs e)
        {
            // Pas de certificat
            // Pas de chronométrage
            // Avec description
            MessageBox.Show("Bonne partie !");
        }

        // Quiz chronométré
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention ! Le chrono va vite se déclencher.");
            // Mettre chrono 
            // Enlevé description

        }

        // Quiz avec obtention du certificat
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonne chance !");

            // Ajout chrono + certificat
            Form1 exam = new Form1();
            exam.ShowDialog();
        }

        
    }
}
