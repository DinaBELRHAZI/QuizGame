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
    public partial class Form1 : Form
    {

        // Variables
        int bonneReponse;
        int questionNumber = 1;
        int score;
        int pourcentage;
        int totalQuestions;
        String description;



        public Form1()
        {
            InitializeComponent();

            // Appel de la méthode askQuestion
            askQuestion(questionNumber);

            // Nombre total de questions
            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            //Identification du bouton cliqué
            var senderObject = (Button)sender;

            //Récupération du tag du bouton cliqué
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            // Si bonne réponse, on ajoute un point au score
            if(buttonTag == bonneReponse)
            {
                // popup avec Message "Bonne réponse + texte description"
                MessageBox.Show(
                    "Bonne réponse ! " 
                    + Environment.NewLine + Environment.NewLine
                    + description
                );
                score++;
            }
            else
            {
                // popup avec Message "Mauvaise réponse + texte description"
                MessageBox.Show(
                    "Mauvaise réponse ! "
                    + Environment.NewLine + Environment.NewLine
                    + description
                );
            }


            // TODO Ajouter certificat en cas de réussite
            if(questionNumber == totalQuestions)
            {
                //Calcul du pourcentage de bonnes réponses
                pourcentage = (int)Math.Round((double)(score * 100 )/ totalQuestions);

                

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

                        + "Cliquez sur OK pour récupérer votre certificat de réussite !"
                    );

                    //Affichage du deuxième form (certificat)
                    if (msg == DialogResult.OK )
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog(); // Shows Form2
                    }
                }
                else
                {
                    var msg = MessageBox.Show(
                        "Fin du quiz ! " + Environment.NewLine
                        + "Vous avez répondu correctement à " + score + " questions sur "
                        + totalQuestions + Environment.NewLine
                        + "Votre poucentage de réussite est de " + pourcentage + "%"
                        + Environment.NewLine + Environment.NewLine

                        + "Cliquez sur OK pour recommencer le quiz !"
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

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Cerceuil_en_plomb_de_Louise_de_Quengo;
                    lblQuestion.Text = "Où le cercueil de Louise de Quengo a-t-il été retrouvé ?";

                    button1.Text = "Rennes";
                    button2.Text = "Paris";
                    button3.Text = "Anger";
                    button4.Text = "Matignon";

                    bonneReponse = 1;

                    description = "Le site où a été retrouvé Louise de Quengo, " +
                        "le couvent des Jacobins à Rennes, est fouillé depuis 2011 par l’Inrap. " + Environment.NewLine +
                        "Entre le XVème et le XVIIIème siècle, " +
                        "cet établissement religieux est devenu un important lieu de pèlerinage et d’inhumation. " + Environment.NewLine +
                        "Ainsi, environ 800 sépultures y ont été mises au jour par les archéologues. " + Environment.NewLine +
                        "Quatre autres cercueils de plomb, datés du XVIIe siècle, ont également été retrouvés. " + Environment.NewLine +
                        "Ils étaient aussi accompagnés de reliquaires en forme de cœur.";


                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Fresque_romaine_découverte_à_Arles;
                    lblQuestion.Text = "A quel style appartient cette fresque romaine trouvée à Arles ?";

                    button1.Text = "Premier style";
                    button2.Text = "Style structural";
                    button3.Text = "Deuxième style Pompéin";
                    button4.Text = "Style à incrustation";

                    bonneReponse = 3;

                    description = "Des fresques exceptionnelles de l’époque romaine ont été mises au jour à Arles en juillet dernier. " + Environment.NewLine +
                        "Mettant en scène des personnages très finement travaillés, " +
                        "ces peintures murales ont dévoilé un style de représentation extrêmement rare. " + Environment.NewLine +
                        "Une première campagne de fouilles avait révélé en 2014 dans une pièce associée à une chambre à coucher, " +
                        "un rare décor peint de deuxième style pompéien, daté entre 70 et 20 avant notre ère.";

                    break;


                case 3:
                    pictureBox1.Image = Properties.Resources.Momie_associée_au_maître_Liuquan;
                    lblQuestion.Text = "Qu'a-t-on retrouvé à la place des organes dans la momie retrouvée dans une statue bouddhiste ?";

                    button1.Text = "Des cailloux";
                    button2.Text = "Des rouleaux de papiers";
                    button3.Text = "Rien";
                    button4.Text = "De la paille";

                    bonneReponse = 2;

                    description = "Selon le chercheur Erik Bruijn, spécialiste de l’art bouddhique, " +
                        "il pourrait s’agir de la momie de Liuquan, un célèbre maître bouddhiste de l’Ecole de méditation chinoise. " +
                        "La momie ne contenait aucun organe." + Environment.NewLine +
                        "Autre chose extraordinaire, des rouleaux de papiers recouverts d’anciens caractères chinois ont été identifiés lors de l’autopsie de la momie. " +
                        "Ils étaient placés là où se trouvaient autrefois les organes du défunt.";
                        

                    break;


                case 4:
                    pictureBox1.Image = Properties.Resources.Tombe_Amphipolis;
                    lblQuestion.Text = "Combien de squelettes ont été retrouvés dans la tombe d’Amphipolis en Grèce ?";

                    button1.Text = "2";
                    button2.Text = "3";
                    button3.Text = "4";
                    button4.Text = "5";

                    bonneReponse = 4;

                    description = "D’une dimension colossale (500 mètres de circonférence), la tombe repose sous un tumulus artificiel de 30 mètres de hauteur. " +
                        "Il serait le plus grand identifié en Asie mineure et se situait autrefois dans une importante cité grecque. " + Environment.NewLine +
                        "Sous le tumulus, la sépulture est gardée par deux énormes sphinx et des cariatides (statues de femmes servant de colonnes) de plus de deux mètres de haut." + Environment.NewLine + Environment.NewLine +
                        "Devant l’ampleur de cette tombe, la question de l’identité de son occupant s’est vite posée. " + Environment.NewLine +
                        "Pourrait-il s’agir de la tombe d’Alexandre le Grand, de sa mère Olympias ou de son épouse Roxane ? " + Environment.NewLine +
                        "La sépulture malheureusement pillée a dans l’ensemble livré peu d’indices. " + Environment.NewLine +
                        "En janvier 2015, la découverte de cinq squelettes, quatre enterrés et un incinéré, ne fait qu’épaissir le mystère. " +
                        "Ont été identifiés le corps d’une femme de plus de 60 ans, d’un bébé et de deux hommes âgés entre 35 et 45 ans.";


                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Vestiges_de_la_cité_engloutie_mise_au_jour_dans_la_baie_de_Kiladha_en_Grèce;
                    lblQuestion.Text = "Qu'a-t-il été retrouvé dans une baie du Péloponnèse en Grèce en août 2015 ?";

                    button1.Text = "Une tombe";
                    button2.Text = "Un navire";
                    button3.Text = "Une cité fortifiée";
                    button4.Text = "Des squelettes de dinosaures";

                    bonneReponse = 3;

                    description = "En août 2015, les vestiges d’une cité fortifiée de l’âge de Bronze sont mis au jour dans une baie du Péloponnèse en Grèce. " + Environment.NewLine +
                        "Une importante découverte qui devrait permettre d’en savoir plus sur cette période de l’histoire de la Grèce. " + Environment.NewLine +
                        "Ces vestiges reposaient sous l’eau, à 1 à 3 mètres de fond. Ils recouvraient une superficie d’au moins 1,2 hectare.";


                    break;


                case 6:
                    pictureBox1.Image = Properties.Resources.Tombeau_de_Toutankhamon;
                    lblQuestion.Text = "Quel égyptologue a émis l'extraordinaire hypothèse que deux pièces inconnues pourraient se trouver dans le tombeau de Toutankhamon ?";

                    button1.Text = "Nicolas Reeves";
                    button2.Text = "Jean-François Champollion";
                    button3.Text = "James Peter Allen";
                    button4.Text = "Thomas George Allen";

                    bonneReponse = 1;

                    description = "En août dernier, l’égyptologue Nicolas Reeves a émis une extraordinaire hypothèse : deux pièces inconnues pourraient se trouver dans le tombeau du célèbre pharaon de la XVIIIe dynastie. " + Environment.NewLine +
                        "Selon l’archéologue, ces deux pièces pourraient abriter la sépulture de la reine Néfertiti, épouse du pharaon Akhénaton, père de Toutankhamon. " + Environment.NewLine +
                        "Nicolas Reeves aurait en effet repéré sur des images de haute précision ainsi que sur des relevés 3D, " +
                        "des fissures et des tracés linéaires sous les couches de peintures du tombeau qui pourraient indiquer la présence de deux portes cachées.";

                    break;


                case 7:
                    pictureBox1.Image = Properties.Resources.Nouveaux_géoglyphes_Nazca_identifiés;
                    lblQuestion.Text = "Combien de géoglyphes auraient été identifiés sur le plateau de Nazca au Pérou en 2015 ?";

                    button1.Text = "12";
                    button2.Text = "57";
                    button3.Text = "14";
                    button4.Text = "24";

                    bonneReponse = 4;

                    description = "24 nouveaux géoglyphes auraient été identifiés sur le plateau de Nazca au Pérou, à 1,5 kilomètre au nord de la ville de Nazca. " + Environment.NewLine +
                        "Ces gigantesques dessins tracés sur le sol et visibles en hauteur ont été découverts par une équipe de chercheurs japonais. " + Environment.NewLine +
                        "Selon ces derniers, " +
                        "ces nouvelles figures pourraient être antérieures (200-400 avant J.C.) aux célèbres géoglyphes de Nazca (400-650 après J.C.) inscrits au patrimoine mondial de l’Unesco.";

                    break;


                case 8:
                    pictureBox1.Image = Properties.Resources.Tombeau_étrusque_mis_au_jour_en_Ombrie;
                    lblQuestion.Text = "Vers quel année la civilisation étrusque commença à prospérer ?";

                    button1.Text = "600 avant J.C";
                    button2.Text = "900 avant J.C";
                    button3.Text = "200 après J.C";
                    button4.Text = "1200 avant J.C";

                    bonneReponse = 2;

                    description = "La civilisation étrusque commença à prospérer vers 900 avant J.C. " + Environment.NewLine +
                        "Elle domina une partie de l’Italie avant de progressivement décliner vers le Vème sicèle avant J.C. " +
                        "et d’être finalement absorbée par l’empire romain entre 300 et 100 avant notre ère.";

                    break;


                case 9:
                    pictureBox1.Image = Properties.Resources.Site_de_Stonehenge_dans_la_plaine_de_Salisbury;
                    lblQuestion.Text = "Combien de pierres ont été retrouvés Salisbury ?";

                    button1.Text = "54";
                    button2.Text = "30";
                    button3.Text = "120";
                    button4.Text = "90";

                    bonneReponse = 4;

                    description = "En septembre 2015, les vestiges d’un autre monument mégalithique ont été mis au jour. " + Environment.NewLine +
                        "En effet, 90 pierres couchées " +
                        "et enterrées sous un mètre de terre ont été découvertes à trois kilomètres du célèbre site de Stonehenge grâce à des techniques de prospection géophysique.";

                    break;


                case 10:
                    pictureBox1.Image = Properties.Resources.Tombe_celte_de_Lavau;
                    lblQuestion.Text = "De quel sexe est le defunt retrouvé dans une tombe princière celte en 2015 ?";

                    button1.Text = "Homme";
                    button2.Text = "Femme";
                    button3.Text = "Mi-femme et mi-homme";
                    button4.Text = "On ne sait pas encore";

                    bonneReponse = 1;

                    description = "Quant à l’occupant de cette tombe, il s’agissait d’un individu richement paré de bijoux " +
                        "et dont le sexe n’avait pas encore pu être déterminé en raison du mauvais état de conservation des ossements." + Environment.NewLine +
                        "Depuis décembre, le voile est levé sur le sexe du défunt, il s’agissait d’un homme. " + Environment.NewLine +
                        "Des analyses d’ADN pourront également être menées afin de déterminer de possibles filiations avec d’autres occupants de tombes, " +
                        "à l’exemple de deux sépultures de l’âge du fer qui pourraient potentiellement contenir des ancêtres de ce prince celte.";

                    break;


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }
    }
}
