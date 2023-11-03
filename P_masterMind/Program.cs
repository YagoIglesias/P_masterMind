using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

///ETML
///Auteur : Yago Iglesias Rodriguez
///Date   : 08.09.2023
///Description : Création du masterminde en C# mode console


namespace masterMinde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création des variables pour stocker les couleurs
            string red = "rouge";
            string green = "vert";
            string blue = "bleu";
            string orange = "orange";
            string black = "noir";
            string white = "blanc";
            string magenta = "magenta";
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

            //Informations du jeu mistermind
            Console.WriteLine("Bienvenue sur Mastermind!");
            Console.WriteLine("Devine le code en 4 couleurs");
            Console.WriteLine("Couleurs possibles: Rouge, Bleu, Vert, Noir, Orange, Blanc, Magenta");
            Console.WriteLine("Vous avez 10 essais pour reussir\n");
            
            //boucle pour relancer une partie
            do
            {
                //dans le tableau colors on à la liste des couleurs
                string[] colors = { red, green, blue, orange, black, white, magenta };
                //créer un numero alletoire entre 0-6 (pour les couleurs)
                int color1 = random.Next(colors.Length);
                int color2 = random.Next(colors.Length);
                int color3 = random.Next(colors.Length);
                int color4 = random.Next(colors.Length);

                //tableau code random
                string[] randomCode = { colors[color1], colors[color2], colors[color3], colors[color4] };

                //code avec les 4 couleurs aleatoires ensembles
                code = randomCode[0] + randomCode[1] + randomCode[2] + randomCode[3];
                //afficher le code secret 
                Console.WriteLine(code);
                //restart le conteur d'essais
                tries = 0;
                //Boucle pour conter le nombre d'essais
                do
                {
                    tries++;
                    Console.WriteLine($"Essai {tries}");
                    //demander les couleurs à l'utilisateur une par une 
                    Console.WriteLine("Inserez votre selection de couleurs");
                    Console.Write("Premier couleur: ");
                    userColor1 = Console.ReadLine().ToLower();
                    Console.Write("Deuxieme couleur: ");
                    userColor2 = Console.ReadLine().ToLower();
                    Console.Write("Troisieme couleur: ");
                    userColor3 = Console.ReadLine().ToLower();
                    Console.Write("Quatrieme couleur: ");
                    userColor4 = Console.ReadLine().ToLower();
                    //code entre au complet
                    answer = userColor1 + userColor2 + userColor3 + userColor4;
                    //retour à la ligne
                    Console.WriteLine();
                    //verifier si le code est correct
                    if (answer == code)
                    {
                        Console.WriteLine($"{code} Bravo vous avez gagne !\n");
                        //si l'utilisateur trouve le code la jeu s'arret
                        break;

                    }
                    else
                    {
                        int badPosition = 0;
                        int good = 0;
                        //Verifier si les couleurs sont presentes dans le code 
                        if (userColor1 == randomCode[0] || userColor1 == randomCode[1] || userColor1 == randomCode[2] || userColor1 == randomCode[3])
                        {
                            //si la premiere couleur n'est pas correct on increment 1 pour la mauvaise possition
                            if (userColor1 != randomCode[0])
                            {
                                badPosition++;   
                                
                            }
                            //si elle est correct on augmente 1 pour la couleur trouvée
                            else
                            {
                                good++;
                                
                            }





                                                                                   
                        }
                        if (userColor2 == randomCode[0] || userColor2 == randomCode[1] || userColor2 == randomCode[2] || userColor2 == randomCode[3])
                        {
                            if (userColor2 != randomCode[1])
                            {
                                 badPosition++;
                            }
                            else
                            {
                                good++;
                            }

                        }
                        if (userColor3 == randomCode[0] || userColor3 == randomCode[1] || userColor3 == randomCode[2] || userColor3 == randomCode[3])
                        {

                            if (userColor3 != randomCode[2])
                            {
                                badPosition++;

                            }
                            else
                            {
                                good++;
                            }
                        }
                        if (userColor4 == randomCode[0] || userColor4 == randomCode[1] || userColor4 == randomCode[2] || userColor4 == randomCode[3])
                        {
                            
                            if (userColor4 != randomCode[3])
                            {
                                badPosition++;

                            }
                            else
                            {
                                good++;
                            }
                        }

                        if(good==0)
                        {
                            Console.WriteLine("Aucune couleur trouvée\n");
                        }

                        //affichage des couleurs correctes
                        Console.WriteLine($"Ok:{good}");
                        //affichage des couleurs fauses
                        Console.WriteLine($"Mauvaise possition:{badPosition}\n");
                    }

                   //Continue tant que l'utilisateur n'a pas gagne
                } while (tries <= 9);
                Console.WriteLine("Voulez-vous rejouer ?");
                Console.WriteLine("Oui/Non");
                replay = Console.ReadLine().ToLower();

            } while (replay == "oui");





            //pas fermer le programme toute de suite 
            Console.ReadLine();



        }
    }
}
