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
        /// Mélange Des piles
        /// </summary>
        /// <param name="pile1">Première pile</param>
        /// <param name="pile2">Deuxième pile</param>
        /// <returns>Retourne la pile mélangée</returns>
        static void Main(string[] args)
        {
            string exempleJoueur = File.ReadText(@"C:\Users\PC1\Documents\Esilv\- S3\Algorithmique & POO\Jeu\Jeu\Joueurs.txt");// renvoie un string de toutes les informations texte trouvée dans le fichier
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

        /* private void ImageExampleForm_Paint(object sender, PaintEventArgs e)
         {
             // Create image.
             //Image newImage = Image.FromFile("SampImag.jpg");

             // Create Point for upper-left corner of image.
             Point ulCorner = new Point(100, 100);

             // Draw image to screen.
             //e.Graphics.DrawImage(newImage, ulCorner);
         }*/
    }
}
}
