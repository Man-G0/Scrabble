using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    class Joueur
    {
        string nom;
        int score;
        List<string> motTrouvés;
        List<Jeton> mainCourante;
        


        public Joueur(string nom) // Constructeur pour créer un joueur en début de partie
        {
            this.nom = nom;
            score = 0;
            motTrouvés = null;
        }
        public Joueur(StreamReader file) // Constructeur pour simuler un joueur en cours de partie
        {

          /*Initialisation du joueur à partir d'un fichier*/
            for (int a = 0; a < 3; a++)
            {
                try
                {
                    string ligneFichier = file.ReadLine();
                    //Console.WriteLine(ligneFichier);
                    string[] TabContenuLigne = ligneFichier.Split(';');
                    if (a == 0) //Lecture de la première ligne du fichier, correspondant à Nom;score
                    {
                        nom = TabContenuLigne[0];
                        //Console.WriteLine(nom);
                        score = Convert.ToInt32(TabContenuLigne[1]);
                    }
                    else if (a == 1) //Lecture de la seconde ligne du fichier contenant la liste de mots trouvés par le joueur
                    {
                        motTrouvés = new List<string>();
                        for (int i = 0; i < TabContenuLigne.Length; i++)
                        {
                            motTrouvés.Add(TabContenuLigne[i]);
                        }
                    }
                    else //Lecture de la troisième ligne du fichier contenant la main courante du joueur
                    {
                        mainCourante = new List<Jeton>();
                        for (int i = 0; i < TabContenuLigne.Length; i++)
                        {
                            /*char lettre = Convert.ToChar(TabContenuLigne[i]);
                            Sac_Jetons sac = new Sac_Jetons("Jetons.txt");
                            SortedList<char, Jeton> s = sac.Sac;
                            s.TryGetValue(lettre);
                            Jeton J = new Jeton()
                            mainCourante.Add(); */
                        }
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

            }
        }

        public void Add_Mot(string mot)
        {
            motTrouvés.Add(mot);
        }

        public string toString()
        {
            string description = $"Le joueur {nom} a actuellement {score} points, a posé {motTrouvés.Count} mots, et a actuellement dans sa main courante :\n";
            for(int i =0; i< mainCourante.Count; i++)
            {
                description += mainCourante[i]+";";
            }
            Console.WriteLine(description);
            return description;
        }

        public void Add_Score(int val)
        {
            score += val;
        }
        public void Add_Main_Courante(Jeton monjeton)
        {
            mainCourante.Add(monjeton);
        }
        public void Remove_Main_Courante(Jeton monjeton)
        {
            mainCourante.Remove(monjeton);
        }
    }
}
