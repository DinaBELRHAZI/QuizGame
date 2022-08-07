using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class quiz_chronometre : Form
    {

        // Variables
        int bonneReponse;
        int questionNumber = 1;
        int score;
        int pourcentage;
        int totalQuestions;
        private int duration = 45;



        public MongoClient client;


        public quiz_chronometre()
        {
            InitializeComponent();

            // Appel de la méthode askQuestion
            askQuestion(questionNumber);

            // Nombre total de questions
            totalQuestions = 10;
            Form1_Load();

        }



        public void Form1_Load()
        {
            MyTimer_Tick = new System.Windows.Forms.Timer();
            // Appel de MyTimer_Tick_Tick() quand le temps est écoulé
            MyTimer_Tick.Tick += new EventHandler(MyTimer_Tick_Tick_1);
            MyTimer_Tick.Interval = 1000; // Durée en milliseconde (1 min)
            MessageBox.Show("Déclenchement du chrono ! Vous avez 45 secondes pour répondre aux 10 questions");
            // Déclenchement du timer
            MyTimer_Tick.Start();

        }

        private void MyTimer_Tick_Tick_1(object sender, EventArgs e)
        {

            

            // Si le temps est écoulé (égal à 0), le quiz est arrêté sinon le décompte continu
            if (duration == 0)
            {
                MyTimer_Tick.Stop();
                MessageBox.Show("Dommage le temps s'est écoulé ! ", "Temps écoulé");
                // Fermeture de la fenêtre
                this.Close();
            }
            else if (duration > 0)
            {
                duration--;
                labelTime.Text = "Temps restant : " + duration.ToString();
            }
        }
     


        private void checkAnswerEvent(object sender, EventArgs e)
        {
            //Identification du bouton cliqué
            var senderObject = (Button)sender;

            //Récupération du tag du bouton cliqué
            int buttonTag = Convert.ToInt32(senderObject.Tag);

           
            if (questionNumber == totalQuestions)
            {

                // Arrêt du timer
                MyTimer_Tick.Stop();

                //Calcul du pourcentage de bonnes réponses
                pourcentage = (int)Math.Round((double)(score * 100) / totalQuestions);



                //Pop up de fin indiquant le résultat
                // Si résultat supérieur ou égale à la moitié du nombre de question => Réussite !
                if (score >= (totalQuestions / 2))
                {
                    var msg = MessageBox.Show(
                        "Fin du quiz ! " + Environment.NewLine
                        + "Vous avez répondu correctement à " + score + " questions sur "
                        + totalQuestions + Environment.NewLine
                        + "Votre poucentage de réussite est de " + pourcentage + "%"
                        + Environment.NewLine + Environment.NewLine

                        + "Cliquez sur OK pour recommencer !"
                    );


                }
                else
                {
                    var msg = MessageBox.Show(
                        "Fin du quiz ! " + Environment.NewLine
                        + "Vous avez répondu correctement à " + score + " questions sur "
                        + totalQuestions + Environment.NewLine
                        + "Votre poucentage de réussite est de " + pourcentage + "%"
                        + Environment.NewLine + Environment.NewLine

                        + "Cliquez sur OK pour recommencer le quiz sinon fermez la page !"
                    );

                }


                // Remise à zéro des questions
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            // Permet d'aller à la question suivante 
            questionNumber++;
            // Appel de la méthode askQuestion avec en paramètre le numéro de la nouvelle question à poser
            askQuestion(questionNumber);
        }


        // Méthode contenant les questions et réponses à appeler
        private void askQuestion(int qnum)
        {


            //connect to mongodb 
            client = new MongoClient("mongodb://localhost:27017");
            // Nom de la base de donnée
            var database = client.GetDatabase("archeo");
            // Nom de la table
            var collectionTest = database.GetCollection<BsonDocument>("quiz_archeo");
            // List des données de la table
            var documents = collectionTest.Find(new BsonDocument()).ToList();
            //MessageBox.Show(documents[0].ToString());
            //MessageBox.Show(documents[1]["id"].ToString() + Environment.NewLine + documents[1]["Description"].ToString() + Environment.NewLine + documents[1]["reponse_3"].ToString() + Environment.NewLine + documents[1]["reponse_4"].ToString());

            // Génération d'un nombre aléatoire compris entre 0 et 19
            Random aleatoire = new Random();
            qnum = aleatoire.Next(20);

            if (qnum == 0)
            {
                qnum = 1;
            }

            // Image 
            pictureBox1.Image = Image.FromFile(documents[qnum]["id"] + ".jpg");

            //Question
            lblQuestion.Text = documents[qnum]["question"].ToString();

            // Les différentes réponses proposées
            button1.Text = documents[qnum]["reponse_1"].ToString();
            button2.Text = documents[qnum]["reponse_2"].ToString();
            button3.Text = documents[qnum]["reponse_3"].ToString();
            button4.Text = documents[qnum]["reponse_4"].ToString();

            // Le tag de la bonne réponse
            bonneReponse = Convert.ToInt32(documents[qnum]["bonne_reponse"].ToString());

            



        }

        
    }
}
