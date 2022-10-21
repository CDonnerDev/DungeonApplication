using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //FIELDS
        //no fields

        //Properties
        //Race CharacterRace
        //EquippedWeapon Weapon

        //Constructors  

        public Player(string name, int hitChance, int block, int maxLife) : base(name, hitChance, block, maxLife)
        {
            //Handle Unique assignment
            //switch (CHaracterRace)
            //{
            //    case Race.Elf:
            //     Hitchance += 5;
            //    MaxHealth -= 5;
            //    break;
            //}
        }

        public Player()
        {

        }
        //Methods
        public override int CalcDamage()
        {
            //return a random value between the weapons min and max damage
            return 0;
        }
        public override int CalcHitChance()
        {
            return 0;
            //HitChance + Weapon BonusHitChance
        }
        public override string ToString()
        {
            //holding variable for the description
            //switch on the character race property
            //case CharacterRace.Elf:
            //description = "Describe an Elf"
            //break;
            return base.ToString();//+some unique description based on the player race
            //hint, use a switch
        }

    }
}
