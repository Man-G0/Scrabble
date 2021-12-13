using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    class Jeton
    {
        // constructeur streamReader ou string FileName + lettre jeton
        int score;
        char lettre;
        int nbJetons;

        public Jeton(char lettre,int score, int nbJetons)
        {
            this.lettre = lettre;
            this.score = score;
            this.nbJetons = nbJetons;
        }

        public char Lettre
        {
            get { return lettre; }
        }

        public int Score
        {
            get { return score; }
        }
        public int NbJetons
        {
            get { return nbJetons; }
        }

        public override string ToString()
        {
            string Pres = $"La lettre {lettre} vaut le score {score} et est présente {nbJetons} fois";
            Console.WriteLine(Pres);
            return Pres;
        }
    }
}
