using System;
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
            //code aleatoir avec les 4 couleurs ensembles
            string code4 = "";

            //creation du code 4 couleurs
            Random code = new Random();

            //dans color on à la liste des couleurs
            string[] color = { red, green, blue, orange, black, white, magenta };
            //créer un numero alletoire entre 0-6 (pour les couleurs)
            int c1 = code.Next(color.Length);
            int c2 = code.Next(color.Length);
            int c3 = code.Next(color.Length);
            int c4 = code.Next(color.Length);

            //tableau
            string[] tabRandom = {color[c1], color[c2], color[c3], color[c4]};
            

            //code avec les 4 couleurs aleatoires ensembles
            code4 = tabRandom[0] + tabRandom[1] + tabRandom[2] + tabRandom[3];
            //test pour voir la création du code
            Console.Write("Le code couleur est : ");
            //Console.WriteLine($"{color[c1]} {color[c2]} {color[c3]} {color[c4]}");
            Console.WriteLine(code4);
            //espace entre reponse et instruction
            Console.WriteLine();

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
                Console.Write("Inserez votre selection de couleurs: ");
                answer = Console.ReadLine();
                //espace
                Console.WriteLine();
                if (answer != code4)
                {
                    Console.WriteLine("Auccune couleur trouvée");

                }
                /*else if ( )
                {
                    Console.WriteLine($"Une couleur correcte: {color[c1]}");
                }*/
                else if (answer == code4)
                {
                    Console.WriteLine($"{code4} OK vous avez gagne");
                }
                


            } while (tries <= 9);

            





            Console.ReadLine();



        }
    }
}
