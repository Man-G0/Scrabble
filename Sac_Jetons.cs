using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    class Sac_Jetons
    {
        SortedList<char, Jeton> sac = new SortedList<char, Jeton>();

        public Sac_Jetons(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            string line = file.ReadLine();
            
            while (line != null)
            {
                string[] tabLigne = line.Split(";");
                char lettre = Convert.ToChar(tabLigne[0]);
                //Console.Write(lettre +" ");
                int score = Convert.ToInt32(tabLigne[1]);
                //Console.Write(score + " ");
                int nbJetons = Convert.ToInt32(tabLigne[2]);
                //Console.WriteLine(nbJetons);

                Jeton j = new Jeton(lettre, score, nbJetons);
                //j.ToString();

                sac.Add(lettre, j);

                line = file.ReadLine();
            }

        }

        public SortedList<char, Jeton> Sac
        {
            get { return sac; }
        }



    }
}
