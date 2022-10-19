using DungeonLibrary;

namespace Dungeon
{
    internal class Program
    { //svm + tab+ tab makes a static void main()
        static void Main(string[] args)
        {
            // Title & Introduction

            #region Title/Introduction

            Console.Title = "DUNGEON OF DOOM";

            Console.WriteLine("Your journey begins..");

            #endregion


            // Variable to track players score

            int score = 0;

            //TODO Weapon object creation
            Weapon sword = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
            //Console.WriteLine(sword);//test the ToString()
            //TODO Player object creation
            //Character test = new Character("Testy McTesterson",30,10,1000);
            //Console.WriteLine(test);

            //TODO Create the main game loop

            #region Main Game Loop

            //Counter Variable - used in the condition of the loop
            bool exit = false;

            do
            {
                 
                //Console.WriteLine(GetRoom());
                Console.WriteLine(GetRoom());

                //TODO Select a random monster to inhabit   

                //Create the gameplay menu loop

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {

                    //Create the main Gameplay menu
                    #region MENU

                    //Prompt the user 
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Information\n" +
                        "M) Monster Information\n" +
                        "X) Exit\n ");

                    //Capture the users menu selection
                    ConsoleKey userChoice = Console.ReadKey(true).Key; //Capture the pressed key, hide the key from the console, and execute immediately

                    //Clear the console
                    Console.Clear();

                    //use branching logic to act upon the users selection
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO Combat

                            Console.WriteLine("Attack");

                            break;

                        case ConsoleKey.R:

                            //TODO Run away - attack of opprotunity

                            Console.WriteLine("Run Away!");

                            break ;

                        case ConsoleKey.P:
                        
                        //TODO Player Stats

                        Console.WriteLine("Player info");
                            break;

                        case ConsoleKey.M:

                            //TODO Monster stats

                            Console.WriteLine("Monster Info");
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:

                            //Exit
                           
                            Console.WriteLine("Nobody likes a quitter...");
                            
                            exit = true;
                            
                            break;

                        default:

                            Console.WriteLine("Invalid Input, Try Again.");

                            break;
                    }
                    #region Check Players Life total

                    //TODO Check players life



                    #endregion


                    #endregion


                } while (!reload && !exit);//&& both have to be true, || one or the other is true


                #endregion


            } while (!exit);//Keep looping as long as exit is false


            #endregion


            //TODO Output the final score
            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));
            

            //Added this line to preserve Console.Title
            Console.ReadKey();

        }//end main()

        private static string GetRoom()
        {
            string[] rooms =
            {
                "You enter a room and smell all the lost souls of the great beyond.",
                "You enter a room and realise you're at an abandoned basement.",
                "The room looks like its all pink and that's the only color you can see.",
                "You enter a room and all you can hear is white noise, the smell of fear lingers on you",
                "You have entered a room that has a fowl smell of urine and manure"

            };

            return rooms[new Random().Next(rooms.Length)];
        }//end GetRoom
    }//end class
}//end namespace




