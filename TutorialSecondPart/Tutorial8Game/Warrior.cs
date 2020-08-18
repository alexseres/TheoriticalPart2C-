using System;

namespace Tutorial8Game
{
    public class Warrior
    {
        // Name Health Attack Maximum Block 
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;


        // Random numbers 
        Random random = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;

        }
        // Attack
        //Generate a random attack from 1 to the maximum attack

        public double Attack()
        {
            return random.Next(1, (int) AttackMax);
        }
        //Block
        //Generate a random attack from 1 to the maximum attack
        public double Block()
        {
            return random.Next(1, (int) BlockMax);
        }


    }
}