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
            string red;
            string green;
            string blue;
            string orange;
            string black;
            string white;
            string magenta;

            //Informations du jeu mistermind
            Console.WriteLine("Bienvenue sur Mastermind!");
            Console.WriteLine("Couleurs possibles: RBVBONM");
            Console.WriteLine("Devine le code en 4 couleurs");
            Console.WriteLine("Vous avez 10 essais");
            //valeur des variables
            red = "R";
            green = "G";
            blue = "B";
            orange = "O";
            black = "B";
            white = "W";
            magenta = "M";
            //creation du code 4 couleurs
            Random color = new Random(red, green, blue, orange, black, white, magenta);





        }
    }
}
