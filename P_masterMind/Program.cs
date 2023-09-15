﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///ETML
///Auteur : Yago Iglesias Rodriguez
///Date   : 08.09.2023
///Description : Création du masterminde en C#


namespace masterMinde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création des variables pour stocker les couleurs
            string red = "Rouge";
            string green = "Vert";
            string blue = "Bleu";
            string orange = "Orange";
            string black = "Noir";
            string white = "Blanc";
            string magenta = "Magenta";
            //Var pour conter les essais
            int tries = 0;
            //var Code utilisateur
            string answer = "";
           
            //creation du code 4 couleurs
            Random code = new Random();
            
            //dans color on à la liste des couleurs
            string[] color = {red, green, blue, orange, black, white, magenta};
            //créer un numero alletoire entre 0-6
            int c1 = code.Next(color.Length);
            int c2 = code.Next(color.Length);
            int c3 = code.Next(color.Length);
            int c4 = code.Next(color.Length);

            //test pour voir la création du code
            Console.WriteLine("Le code couleur est : ");
            Console.WriteLine($"{color[c1]} {color[c2]} {color[c3]} {color[c4]}");

            //Informations du jeu mistermind
            Console.WriteLine("Bienvenue sur Mastermind!");
            Console.WriteLine("Devine le code en 4 couleurs");
            Console.WriteLine("Couleurs possibles: Rouge, Bleu, Vert, Noir, Orange, Blanc, Magenta");
            Console.WriteLine("Vous avez 10 essais pour reussir\n");

            //Boucle pour conter le nombre d'essais
            do
            {
                tries++;
                Console.WriteLine($"Essai {tries}");
                answer = Console.ReadLine();

                if (answer != color[c1] || answer != color[c2] || answer != color[c3] || answer != color[c4])
                {
                    Console.WriteLine("Auccune couleur trouvée");

                }
                else if (answer == color[c1] || answer != color[c2] || answer != color[c3] || answer != color[c4])
                {
                    Console.WriteLine($"{color[c1]} OK");
                }
                


            } while (tries <= 9);

            





            Console.ReadLine();



        }
    }
}
