using System;
using dotnetPOO.src.Entities;


namespace dotnetPOO{
    class Program{

        static void Main(string[] args){

            int input = SelectClass();
            
            if (input == 1){ // GAME AS A KNIGHT
                Console.WriteLine("What is your name as a Knight?");
                string name = Console.ReadLine();
                Knight hero = new Knight(name);

                Console.WriteLine($"\n{hero.ToString()}");
                Explore();
            }
            
            else if (input == 2){ //GAME AS A WIZARD
                Console.WriteLine("What is your name as a Wizard?");
                string name = Console.ReadLine();
                Wizard hero = new Wizard(name);

                Console.WriteLine($"\n{hero.ToString()}");
                Explore();
            }

            else if (input == 3){ //GAME AS A NINJA
                Console.WriteLine("What is your name as a Ninja?");
                string name = Console.ReadLine();
                Ninja hero = new Ninja(name);

                Console.WriteLine($"\n{hero.ToString()}");
                Explore();
            }

            else if (input == 4){ //GAME AS A ARCHER
                Console.WriteLine("What is your name as an Archer?");
                string name = Console.ReadLine();
                Archer hero = new Archer(name);

                Console.WriteLine($"\n{hero.ToString()}");
                Explore();
            }

            else throw new ArgumentException("There is no such option, so bye bye.");            

        }


        static void Explore(){

            Console.WriteLine($@"Select to explore or select any other to exit: 
        [1] - Turn left
        [2] - Go ahead
        [3] - Turn right");
            
            string input = Console.ReadLine();

            if (input == "1"){ // LEFT
                Console.WriteLine("\nYou turned left and... Nothing happened, yet. \nPress Enter.\n");
                Console.ReadLine();

                Explore();
            }

            else if (input == "2"){ // AHEAD
                Console.WriteLine("\nYou went ahead and... Nothing happened, yet. \nPress Enter.\n");
                Console.ReadLine();

                Explore();
            }

            else if (input == "3"){ // RIGHT
                Console.WriteLine("\nYou turned right and... Nothing happened, yet. \nPress Enter.\n");
                Console.ReadLine();

                Explore();
            }

            else{
                Console.WriteLine("It was nice playing with you! Goodbye, take care! :)");
                Console.ReadLine();
            }
        }

        static int SelectClass(){
            Console.WriteLine("Hello, welcome to Dungeons In Otherworld!"); // yes, it was supposed to be a joke (DIO)
            Console.WriteLine(@"
Please select your class: 
    [1] - Knight
    [2] - Wizard
    [3] - Ninja
    [4] - Archer");

            int input = int.Parse(Console.ReadLine());
            return input;
        }
    
    
    }





    
}