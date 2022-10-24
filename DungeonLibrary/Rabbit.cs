using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Rabbit : Monster
    {
        //FIELDS
        //no fields

        //Properties
        public bool IsFluffy { get; set; }
        //Constructors  
        //Default Ctor to set some basic values for a generic monster of this type
        public Rabbit()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Rabbit";
            Life = MaxLife;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "It's just a cute little bunny...why would you hurt it";
            IsFluffy = false;
        }
        //Parent Complaint (Monster) CTOR
        //Intellisense quick action on the parent name in the class declaration
        public Rabbit(string name, int hitChance, int block, int maxLife, //Character
            int maxDamage, int minDamage, string description,//Monster
            bool isFluffy) //Rabbit
            : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsFluffy=isFluffy;
        }

        //Methods

        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "It's fluffy" : "It's not so fluffy");
        }

        //Character CalcBlock = Block
        //Monster CalcBlock = Block
        //Rabbit CalcBlock = not block
        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            //Apply a 50% increase to the rabbits if its fluffy
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}
