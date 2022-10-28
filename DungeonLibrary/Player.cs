using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //Fields // Funny
        //no fields

        //Properties // People
        //Race CharacterRace
        //EquippedWeapon Weapon
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //Constructors // Collect
        public Player(string name, int hitChance, int block, int maxLife, Race characterRace, Weapon equippedWeapon) : base(name, hitChance, block, maxLife)
        {
            //handle unique assignment
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            //potential expansion, not required
            switch (CharacterRace)
            {
                case Race.Elf:
                   HitChance += 5;
                  MaxLife -= 5;
                    break;
                case Race.Human:
                    HitChance += 2;
                    MaxLife -= 2;
                    break;
                case Race.Orc:
                    HitChance += 6;
                    MaxLife -= 6;
                    break;
                case Race.Dwarf:
                    HitChance += 3;
                    MaxLife -= 3;
                    break;
                case Race.Tiefling:
                    HitChance += 1;
                    MaxLife -= 1;
                    break;
            }
        }
        public Player()
        {

        }

        //Methods // Monkeys
        public override int CalcDamage()
        {
            //return a random value between the Weapon's min and max damage
            return new Random().Next(this.EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //player.EquippedWeapon.DateCreated.Year
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
            //HitChance + Weapon BonusHitChance
        }
        public override string ToString()
        {
            string description = CharacterRace.ToString().Replace('_', ' ');

            //holding variable for the description
            switch (CharacterRace)
            {
                case Race.Human:
                    Console.WriteLine("Humans are the mortal men of middle earth");
                        break;
                case Race.Orc:
                    Console.WriteLine("Orcs are the smelliest creature that terrorizes midddle earth");
                    break;
                case Race.Elf:
                    Console.WriteLine("Elves are the fairest but also some are the scariest in all of middle earth");
                    break;
                case Race.Dwarf:
                    Console.WriteLine("Dwarves are the best miners and makers of weapons and armor");
                    break;
                case Race.Khajit:
                    Console.WriteLine("The people look like cats.....Are you sure you want to be a cat?");
                    break ;
                case Race.Dragonborn:
                    Console.WriteLine("Hey, you. You're finally awake");
                    break;
                case Race.Tiefling:
                    Console.WriteLine("This Humanoid Race is here to destroy all in their path, do you join them?");
                    break;
                case Race.Gnome:
                    Console.WriteLine("The Gnomes are a WEIRD race, they are the shortest and the least fashionable");
                    break;
                case Race.Halflings:
                    Console.WriteLine("Half Human Half Elf, what a crazy sight that could've been, they hate each other");
                    break;
                  
                   

            }
            //case CharacterRace.Elf: 
            //  description = "Describe an Elf"
            //  break;            
            return base.ToString() + $"\nWeapon:\n{EquippedWeapon}\nBlock: {Block}\n" +
                $"Description: {description}";//+some unique description based on the player race.
            //hint, use a switch
        }
    }
}