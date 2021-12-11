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


        public Joueur(string nom)
        {
            this.nom = nom;
            score = 0;
            motTrouvés = null;
        }
        public Joueur(StreamReader fil)
        {
            string Contenu = fil.ReadLine();
            nom = exempleJoueur[0];
            motTrouvés = new List<string>(motTrouvés.Count + 1);
            motTrouvés[motTrouvés.Count + 1] = exempleJoueur[1]; // faut reprendre parce que faut séparer les mots

        }

        public void Add_Mot(string mot)
        {

        }
    }
}
