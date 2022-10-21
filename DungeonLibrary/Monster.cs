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
        private int _maxDamage;
        private int _damage;
        private int _minDamage;
        private string _description;
        //Properties
        //MinDamage = int - can't be more than MaxDamage, or less than 0.
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = (value > 0 && value <= MaxDamage ? value : 0);}
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

        public Monster(string name, int hitChance, int block, int maxLife, int maxDamage, int damage, int minDamage, string description) : base(name, hitChance, block, maxLife)
        {
            //remember to set MaxDamage FIRST!!!
            MaxDamage = maxDamage;
            Damage = damage;
            MinDamage = minDamage;
            Description = description;
        }

        //Methods
        public override string ToString()
        {
            return $"----{Name}----\n" +
                   $"Life: {MinDamage} of {MaxDamage}\n" +
                   //MinDamage to MaxDamage
                   $"Hit Chance: {HitChance}%\n" +
                   $"Block: {Description}";
                    //Description
        }
        public override int CalcDamage()
        {
            return base.CalcDamage();
            //Return a random number between Monster min and max damage
        }
    }
}
