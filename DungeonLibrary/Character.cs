﻿namespace DungeonLibrary
{
    //The "Abstract" modifier:
    //Denotes this datatype is "incomplete" -- we don't intend to make a character object,
    //but will instead use character as a starting point for other, more specific types
    public abstract class Character
    {


        

        //Fields//Funny
        private int _life;
        private string? _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        //Properties//People

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            //Life can not be more than MaxLife
            set
            {
                if (value <= _maxLife)//prop or field
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
              //_life = value <= MaxLife ? value : MaxLife;
            }//end set
        }//end life prop

        //Constructors//Collect
        public Character(string name, int hitChance, int block, int maxLife)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = maxLife;//Default life to be the same as MaxLife
        }

        public Character()
        {

        }
        //Methods//Monkeys

        public override string ToString()
        {
            return $"----{Name}----\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}";
        }

        public virtual int CalcBlock() { return _block; }
        public virtual int CalcHitChance() { return HitChance; }
        public virtual int CalcDamage() { return 0; }

    }
}