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
        string[,] plateau = new string[15, 15];

        #region Constructeur
        public Plateau()
        {
            //Initialisation du plateau
            
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                

                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    plateau[i, j] = "   ";

                }


            }
            AffichagePlateau();

        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Initialisation d'une matrice avec dans chaque case le coefficient multiplicateur du plateau de lettre ou de mot correspondant 
        /// </summary>   
        /// <returns>Retourne la matrice des coefficients</returns>
        public string[,] InitialisationMatriceMultiplicateurs()
        {
            string[,] matriceMultiplicateur = new string[15, 15];
            for (int i = 0; i < matriceMultiplicateur.GetLength(0); i++)
            {
                for (int j = 0; j < matriceMultiplicateur.GetLength(1); j++)
                {
                    matriceMultiplicateur[i, j] = " ";
                    switch (i)
                    {
                        case 0:
                            if (j == 0 || j == 7 || j == 14)
                            {
                                matriceMultiplicateur[i, j] = "mot compte triple";
                            }
                            else if (j == 3 || j == 11)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }

                            break;
                        case 1:
                            if (j == 1 || j == 13)
                            {
                                matriceMultiplicateur[i, j] = "mot compte double";
                            }
                            else if (j == 5 || j == 9)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte triple";
                            }

                            break;
                        case 2:
                            if (j == 2 || j == 12)
                            {
                                matriceMultiplicateur[i, j] = "mot compte double";
                            }
                            else if (j == 6 || j == 8)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }

                            break;
                        case 3:
                            if (j == 3 || j == 11)
                            {
                                matriceMultiplicateur[i, j] = "mot compte double";
                            }
                            else if (j == 0 || j == 7 || j == 14)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }
                            break;
                        case 4:
                            if (j == 4 || j == 10)
                            {
                                matriceMultiplicateur[i, j] = "mot compte double";
                            }
                            break;
                        case 5:
                            if (j == 1 || j == 5 || j == 9 || j == 13)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte triple";
                            }
                            break;
                        case 6:
                            if (j == 2 || j == 6 || j == 8 || j == 12)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }
                            break;
                        case 7:
                            if (j == 0 || j == 14)
                            {
                                matriceMultiplicateur[i, j] = "mot compte triple";
                            }
                            else if (j == 3 || j == 11)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }
                            else if (j == 7)
                            {
                                matriceMultiplicateur[i, j] = "milieu";
                            }
                            break;
                        case 8:
                            if (j == 2 || j == 6 || j == 8 || j == 12)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }
                            break;
                        case 9:
                            if (j == 1 || j == 5 || j == 9 || j == 13)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte triple";
                            }
                            break;
                        case 10:
                            if (j == 4 || j == 10)
                            {
                                matriceMultiplicateur[i, j] = "mot compte double";
                            }
                            break;
                        case 11:
                            if (j == 3 || j == 11)
                            {
                                matriceMultiplicateur[i, j] = "mot compte double";
                            }
                            else if (j == 0 || j == 7 || j == 14)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }
                            break;
                        case 12:
                            if (j == 2 || j == 12)
                            {
                                matriceMultiplicateur[i, j] = "mot compte double";
                            }
                            else if (j == 6 || j == 8)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }

                            break;
                        case 13:
                            if (j == 1 || j == 13)
                            {
                                matriceMultiplicateur[i, j] = "mot compte double";
                            }
                            else if (j == 5 || j == 9)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte triple";
                            }
                            break;
                        case 14:
                            if (j == 0 || j == 7 || j == 14)
                            {
                                matriceMultiplicateur[i, j] = "mot compte triple";
                            }
                            else if (j == 3 || j == 11)
                            {
                                matriceMultiplicateur[i, j] = "lettre compte double";
                            }
                            break;
                    }
                }
            }
            return matriceMultiplicateur;
        }



        /// <summary>
        /// Permet l'affichage du plateau en couleur grace à la matrice de coefficients multiplicateurs
        /// </summary>   

        public void AffichagePlateau()
        {
            
            string[,] matriceMultiplicateurs = InitialisationMatriceMultiplicateurs();

            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;// a partir de maintenant la console est verte
                Console.ForegroundColor = ConsoleColor.Black;// a partir de maintenant texte en noir
                
                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    if (matriceMultiplicateurs[i, j] == "mot compte triple")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        

                    }
                    else if (matriceMultiplicateurs[i, j] == "lettre compte double")
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        
                    }
                    else if (matriceMultiplicateurs[i, j] == "mot compte double"|| matriceMultiplicateurs[i, j] == "milieu")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        
                    }
                    else if (matriceMultiplicateurs[i, j] == "lettre compte triple")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        
                    }


                    Console.Write(plateau[i, j]);
                    Console.BackgroundColor = ConsoleColor.Green;// a partir de maintenant la console est verte
                   
                }
                Console.BackgroundColor = ConsoleColor.Black;// a partir de maintenant la console est noire
                Console.ForegroundColor = ConsoleColor.Gray;// a partir de maintenant texte en blanc
                Console.WriteLine();
            }

            #region Définition couleurs
            Console.WriteLine();
            Console.Write("- La couleur ");
            Console.BackgroundColor = ConsoleColor.Green;// a partir de maintenant la console est verte
            Console.ForegroundColor = ConsoleColor.Black;// a partir de maintenant texte en noir
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;// a partir de maintenant la console est noire
            Console.ForegroundColor = ConsoleColor.Gray;// a partir de maintenant texte en blanc
            Console.WriteLine(" correspond à : pas de multiplicateur");

            Console.Write("- La couleur ");
            Console.BackgroundColor = ConsoleColor.DarkRed;// a partir de maintenant la console est verte
            Console.ForegroundColor = ConsoleColor.Black;// a partir de maintenant texte en noir
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;// a partir de maintenant la console est noire
            Console.ForegroundColor = ConsoleColor.Gray;// a partir de maintenant texte en blanc
            Console.WriteLine(" correspond à : mot compte triple");

            Console.Write("- La couleur ");
            Console.BackgroundColor = ConsoleColor.Cyan;// a partir de maintenant la console est verte
            Console.ForegroundColor = ConsoleColor.Black;// a partir de maintenant texte en noir
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;// a partir de maintenant la console est noire
            Console.ForegroundColor = ConsoleColor.Gray;// a partir de maintenant texte en blanc
            Console.WriteLine(" correspond à : lettre compte double");

            Console.Write("- La couleur ");
            Console.BackgroundColor = ConsoleColor.Gray;// a partir de maintenant la console est verte
            Console.ForegroundColor = ConsoleColor.Black;// a partir de maintenant texte en noir
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;// a partir de maintenant la console est noire
            Console.ForegroundColor = ConsoleColor.Gray;// a partir de maintenant texte en blanc
            Console.WriteLine(" correspond à : mot compte double");

            Console.Write("- La couleur ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;// a partir de maintenant la console est verte
            Console.ForegroundColor = ConsoleColor.Black;// a partir de maintenant texte en noir
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;// a partir de maintenant la console est noire
            Console.ForegroundColor = ConsoleColor.Gray;// a partir de maintenant texte en blanc
            Console.WriteLine(" correspond à : Lettre compte triple");
            Console.WriteLine();
            #endregion
        }



        #endregion
    }
}
