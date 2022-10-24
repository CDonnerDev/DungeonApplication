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

            #region Possible Expansion - Levels of Play - Block 5

            //Possible Expansion: 
            //Define levels of play
            //int[] levels = { 5, 12, 20, 30, 45 };//Use with experience property in Character
            //inherited down to Player and Monster, to scale levelling.

            #endregion


            // Variable to track players score

            int score = 0;

            //TODO Weapon object creation
            Weapon sword = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
            #region Possible expansion
            //Create a list of weapoons, and either give the player a random weapon, let them pick, or let them pick a weapontype and give them a weapon
            //off of that type
            #endregion

            //Console.WriteLine(sword);//test the ToString()
            //TODO Player object creation
            #region Player Object creation
            #region Possible Expansion - Player Customization - Block 5

            //Possible Expansion: 
            //Allow player to define chatacter name
            //Console.Write("Enter your name: ");
            //string userName = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Welcome, {0}! Your journey begins...", userName);
            //Console.ReadKey();
            //Console.Clear();

            //Display a list of races and let them pick one, or assign one randomly.
            #endregion

            Player player = new Player("Leeroy Jenkins", 70, 5, 40, Race.Elf, sword);

            #endregion           

            #region Main Game Loop

            //Counter Variable - used in the condition of the loop
            bool exit = false;

            do
            {
                 //Generate a random room the player will enter
                
                Console.WriteLine(GetRoom());

                //Select a random monster to inhabit   
                Monster monster = Monster.GetMonster();
                Console.WriteLine("\n In this room..." + monster.Name);
                //Create the gameplay menu loop

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {

                    
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

                            //Combat
                            #region Possible Expansion - Racial/Weapon Bonus

                            //Possible Expansion: Give certain character races or characters with a certain weapon an advantage
                            //if (player.CharacterRace == Race.DarkElf)
                            //{
                            //    Combat.DoAttack(player, monster);
                            //}
                            #endregion

                            Combat.DoBattle(player, monster);
                            //Check if the monster is dead
                            if (monster.Life <= 0 )
                            {
                                //loot,exp, gold, whatever.

                                //Use Green to indicate winning
                                Console.ForegroundColor = ConsoleColor.Green;

                                //output the result
                                Console.WriteLine($"\nYou killed {monster.Name}!");

                                //Reset the color 
                                Console.ResetColor();

                                //leave the inner loop
                                reload = true;

                                //update the score
                                score++;
                            }

                            break;

                        case ConsoleKey.R:

                            //Run away - attack of opprotunity

                            Console.WriteLine("Run Away!!!");

                            //Monster gets an "Attack of opprotunity"
                            Console.WriteLine(monster.Name + " attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();//for formatting

                            reload = true;
                            break;

                        case ConsoleKey.P:
                        
                        //Player Stats

                        Console.WriteLine(player);

                            break;

                        case ConsoleKey.M:

                            //Monster stats

                            Console.WriteLine(monster);

                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            //Exit
                           
                            Console.WriteLine("Nobody likes a quitter...");
                            
                            exit = true;
                            
                            break;

                        default:

                            Console.WriteLine("Invalid Input, Try Again.");

                            break;
                    }
                    #region Check Players Life total

                    //Check players life
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude... you died! \a");
                        exit |= true;
                    }


                    #endregion


                    #endregion


                } while (!reload && !exit);//&& both have to be true, || one or the other is true


                #endregion


            } while (!exit);//Keep looping as long as exit is false


            #endregion

            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));
            

            //Added this line to preserve Console.Title
           

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