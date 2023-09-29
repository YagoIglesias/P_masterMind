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
            //choix premier couleur par l'utilisateur
            string userColor1 = "";
            //deuxieme couleur
            string userColor2 = "";
            //troisieme 
            string userColor3 = "";
            //quatrieme
            string userColor4 = "";
            //var Code utilisateur entier
            string answer = "";
            //code aleatoir avec les 4 couleurs ensembles
            string code = "";
            //var rejoue
            string replay = "";

            //creation du code 4 couleurs avec un random
            Random random = new Random();

            //dans le tableau color on à la liste des couleurs
            string[] colors = { red, green, blue, orange, black, white, magenta };
            //créer un numero alletoire entre 0-6 (pour les couleurs)
            int color1 = random.Next(colors.Length);
            int color2 = random.Next(colors.Length);
            int color3 = random.Next(colors.Length);
            int color4 = random.Next(colors.Length);

            //tableau code random
            string[] randomCode = {colors[color1], colors[color2], colors[color3], colors[color4]};

            //code avec les 4 couleurs aleatoires ensembles
            code = randomCode[0] + randomCode[1] + randomCode[2] + randomCode[3];
            //test pour voir la création du code
            Console.Write("Le code couleur est : ");
            //Console.WriteLine($"{colors[color1]} {colors[color2]} {colors[color3]} {colors[color4]}");
            Console.WriteLine(code);
            //espace entre reponse et instruction
            Console.WriteLine();

            //Informations du jeu mistermind
            Console.WriteLine("Bienvenue sur Mastermind!");
            Console.WriteLine("Devine le code en 4 couleurs");
            Console.WriteLine("Couleurs possibles: Rouge, Bleu, Vert, Noir, Orange, Blanc, Magenta");
            Console.WriteLine("Vous avez 10 essais pour reussir\n");

            do
            {

                //Boucle pour conter le nombre d'essais
                do
                {
                    tries++;
                    Console.WriteLine($"Essai {tries}");
                    Console.WriteLine("Inserez votre selection de couleurs");
                    Console.Write("Premier couleur: ");
                    userColor1 = Console.ReadLine();
                    Console.Write("Deuxieme couleur: ");
                    userColor2 = Console.ReadLine();
                    Console.Write("Troisieme couleur: ");
                    userColor3 = Console.ReadLine();
                    Console.Write("Quatrieme couleur: ");
                    userColor4 = Console.ReadLine();
                    //code entre au complet
                    answer = userColor1 + userColor2 + userColor3 + userColor4;
                    //retour à la ligne
                    Console.WriteLine();
                    //verifier si le code est correct
                    if (answer == code)
                    {
                        Console.WriteLine($"{code} OK, vous avez gagne !");
                        //si l'utilisateur trouve le code la jeu s'arret
                        break;

                    }
                    //Verifier si les couleurs sont presentes dans le code 
                    else if (userColor1 == randomCode[0] || userColor1 == randomCode[1] || userColor1 == randomCode[2] || userColor1 == randomCode[3])
                    {
                        Console.WriteLine("Premier couleur est dans le code");
                    }
                    if (userColor2 == randomCode[0] || userColor2 == randomCode[1] || userColor2 == randomCode[2] || userColor2 == randomCode[3])
                    {
                        Console.WriteLine("Deuxieme couleur est dans le code");

                    }
                    if (userColor3 == randomCode[0] || userColor3 == randomCode[1] || userColor3 == randomCode[2] || userColor3 == randomCode[3])
                    {
                        Console.WriteLine("Troisieme couleur est dans le code");
                    }
                    if (userColor4 == randomCode[0] || userColor4 == randomCode[1] || userColor4 == randomCode[2] || userColor4 == randomCode[3])
                    {
                        Console.WriteLine("Quatrieme couleur est dans le code");
                    }
                    //Verifier si auccune couleur trouvée
                    else if (answer != code)
                    {
                        Console.WriteLine("Auccune couleur trouvée\n");

                    }


                    //Continue tant que l'utilisateur n'a pas gagne
                } while (tries <= 9);
                Console.WriteLine("Voulez-vous rejouer ?");
                Console.WriteLine("Oui/Non");
                replay = Console.ReadLine().ToLower()
                    ;

            } while (replay == "oui");

            





            Console.ReadLine();



        }
    }
}
