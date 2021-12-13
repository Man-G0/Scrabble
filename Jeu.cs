using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    class Jeu
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="pile1">Première pile</param>
        /// <param name="pile2">Deuxième pile</param>
        /// <returns>Retourne la pile mélangée</returns>
        static void Main(string[] args)
        {
            #region ExempleJoueur
            StreamReader file = new StreamReader("Joueurs.txt");
            Joueur JoueurExemple = new Joueur(file);
            JoueurExemple.toString();
            #endregion


            Plateau PlateauExemple = new Plateau();
            Dictionnaire DictionnaireFrancais = new Dictionnaire("français","Francais.txt");

            Sac_Jetons A = new Sac_Jetons("Jetons.txt");
            SortedList<char, Jeton> s = A.Sac;
            Jeton J = s.ElementAt('A').Value;
            J.ToString();

        }

        static void BazarASupprimer()
        {
            string exempleJoueur = File.ReadAllText(@"C:\Users\PC1\Documents\Esilv\- S3\Algorithmique & POO\Jeu\Jeu\Joueurs.txt");// renvoie un string de toutes les informations texte trouvée dans le fichier
            File.WriteAllText(@"C:\Users\PC1\Documents\Esilv\- S3\Algorithmique & POO\Jeu\Jeu\Nouveau document texte.txt", "hello");
            Console.WriteLine(exempleJoueur + "\n");



            string[] exempleInfosJoueur = File.ReadAllLines(@"C:\Users\PC1\Documents\Esilv\- S3\Algorithmique & POO\Jeu\Jeu\Joueurs.txt"); // renvoies un tableau avec dans chaque case un string d'une ligne du texte trouvé dans le document
            for (int i = 0; i < exempleInfosJoueur.Length; i++)
            {
                Console.WriteLine($"Ligne {i + 1} :" + exempleInfosJoueur[i]);
            }

            Plateau a = new Plateau();
            //Console.BackgroundColor = ConsoleColor.Green;// a partir de maintenant la console est verte
            //Console.ForegroundColor = ConsoleColor.Black;// a partir de mnt texte en noir




            //Image Hello = Image.FromFile("SampImag.jpg");
            //Image img = new Image();
            //img.ImageUrl = dr["photo"];
        }
    }
}

