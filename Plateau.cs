using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    class Plateau
    {
        string[,] plateau = new string[17, 15];

        #region Constructeur
        public Plateau()
        {
            //Initialisation du plateau
            for (int i = 0; i < plateau.GetLength(1); i++)
            {
                plateau[0, i] = "___";
                plateau[16, i] = "———";
            }

            for (int i = 1; i < plateau.GetLength(0) - 1; i++)
            {


                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    plateau[i, j] = "|  ";

                    if (j == plateau.GetLength(1) - 1)
                    {
                        plateau[i, j] += "|";
                    }


                }


            }
            AffichagePlateau();

        }
        #endregion

        #region Méthodes

        public void AffichagePlateau()
        {
            Console.BackgroundColor = ConsoleColor.Green;// a partir de maintenant la console est verte
            Console.ForegroundColor = ConsoleColor.Black;// a partir de maintenant texte en noir

            Console.WriteLine(" --1--2--3--4--5--6--7--8--9--10-11-12-13-14-15");
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;// a partir de maintenant la console est verte
                Console.ForegroundColor = ConsoleColor.Black;// a partir de maintenant texte en noir
                if (i > 0 && i < 10)
                {
                    Console.Write(i + " ");
                }
                else if (i >= 10 && i < plateau.GetLength(0) - 1)
                {
                    Console.Write(i);
                }

                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    Console.Write(plateau[i, j]);
                }
                Console.BackgroundColor = ConsoleColor.Black;// a partir de maintenant la console est noire
                Console.ForegroundColor = ConsoleColor.Gray;// a partir de maintenant texte en blanc
                Console.WriteLine();
            }
        }

        #endregion
    }
}
