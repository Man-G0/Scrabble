using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    class Dictionnaire
    {
        #region Attributs
        string langue;
        Dictionary<int, List<string>> Dictio = new Dictionary<int, List <string>>();
        #endregion

        #region Constructeur

        public Dictionnaire(string langue, string file)
        {
            StreamReader str = new StreamReader(file);
            string line="";
            int i = 0;
            int longueurMot=2;
            while (line != null)
            {
                try
                {

                    line = str.ReadLine();
                    
                    if (i%2 == 0)
                    {
                        longueurMot = Convert.ToInt32(line);                        
                    }
                    else if(i%2!=0)
                    {
                        string[] LigneDico = line.Split(" ");
                        List<string> ListeMotDico = new List<string>();
                        for (int a =0; a < LigneDico.Length; a++)
                        {                           
                            ListeMotDico.Add(LigneDico[a]);
                        }
                        Dictio.Add(longueurMot, ListeMotDico);
                    }
                    i++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                
            }
        }
        #endregion

    }
}
