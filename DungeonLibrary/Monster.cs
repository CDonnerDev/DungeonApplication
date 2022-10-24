using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //FIELDS
        //MinDamage = int - can't be more than MaxDamage, or less than 0.
        private int _minDamage;
        private int _maxDamage;
        
        private string _description;
        //Properties
        //MinDamage = int - can't be more than MaxDamage, or less than 0.
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
      
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = (value > 0 && value <= MaxDamage ? value : 1);}
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }



        //MaxDamage as an int
        //Description as a string

        //Constructors  
        public Monster()
        {

        }

        public Monster(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife)
        {
            //remember to set MaxDamage FIRST!!!
            MaxDamage = maxDamage;
            
            Description = description;
            MinDamage = minDamage;
        }

       

        //Methods
        public override string ToString()
        {
            return $"----{Name}----\n" +
                   $"Life: {MinDamage} of {MaxDamage}\n" +
                   //MinDamage to MaxDamage
                   $"Hit Chance: {HitChance}%\n" +
                   $"Block: {Block}\n" +
                   $"Description: {Description}";
                   
                    //Description
        }
        public override int CalcDamage()
        {
            return base.CalcDamage();
            //Return a random number between Monster min and max damage
            return new Random().Next(MinDamage, MaxDamage);
        }

        public static Monster GetMonster()
        {
            Rabbit rabbit = new Rabbit(name:"White Rabbit",maxLife: 25,hitChance: 50,block: 20,maxDamage: 8,minDamage: 2,description:"Thats no ordinary rabbit! Look at the bones!", isFluffy:true);
            Rabbit babyRabbit = new Rabbit();

            Vampire vampire = new Vampire(name: "Dracula", maxLife: 30, hitChance: 70, block: 8, minDamage: 1, maxDamage: 8,
                description: "The father of all the undead");

            Turtle turtle = new Turtle(name: "Mickey", maxLife: 25, hitChance: 50, block: 10, maxDamage: 4, minDamage: 1,
                description: "He is no longer a teenager, but he is still a mutant turtle", bonusBlock: 3, hidePercent: 10);

            Turtle babyTurtle = new Turtle();

            Dragon dragon = new Dragon(name: "smaug", maxLife: 35, hitChance: 65, block: 20, maxDamage: 15, minDamage: 1, description: "The last" +
                "great dragon", isScaly: true);
            Dragon babyDragon = new Dragon();

            List<Monster> monsters = new List<Monster>()
            {
                rabbit, 
                babyRabbit,babyRabbit,babyRabbit,
                vampire,
                turtle,
                babyTurtle,babyTurtle,babyTurtle,
                dragon,
                babyDragon,babyDragon,babyDragon
            };
            int randomIndex = new Random().Next(monsters.Count);
            Monster monster = monsters[randomIndex];
            return monster;
        }
    }
}
