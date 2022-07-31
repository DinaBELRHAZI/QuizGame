using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public class quiz
    {

        public int id { get; set; }
        public string question { get; set; }
        public string reponse_1 { get; set; }
        public string reponse_2 { get; set; }
        public string reponse_3 { get; set; }
        public string reponse_4 { get; set; }
        public int bonne_reponse { get; set; }
        public string description { get; set; }
        

        public quiz(int id, string question, string reponse_1, string reponse_2, string reponse_3, string reponse_4, int bonne_reponse, string description)
        {
            this.id = id;
            this.question = question;
            this.reponse_1 = reponse_1;
            this.reponse_2 = reponse_2;
            this.reponse_3 = reponse_3;
            this.reponse_4 = reponse_4;
            this.bonne_reponse = bonne_reponse;
            this.description = description;
        }

       

        public override string ToString()
        {
            return this.id + " " + this.question + " " + this.bonne_reponse + " " + this.description ;
        }
    }
}
