using System;

namespace Tutorial8Game
{
    public class Battle
    {
        //Startfigt 
        //Warrior1 Warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "game over")
                {
                    Console.WriteLine("Game over");
                    break;
                } if (GetAttackResult(warrior2, warrior1) == "game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
            }
        }
        

        // GetAttackResult
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAttackAmount = warriorA.Attack();
            double warriorBlockAmount = warriorB.Block();

            double damageToWarriorB = warriorAttackAmount - warriorBlockAmount;
            if (damageToWarriorB >= 0)
            {
                warriorB.Health = warriorB.Health - damageToWarriorB;
            }
            else damageToWarriorB = 0;

            Console.WriteLine("{0} attacks {1} amd Deals {2} Damage",warriorA.Name,warriorB.Name,damageToWarriorB);
            Console.WriteLine("{0} Has {1} Health \n ", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorius", warriorB.Name, warriorA.Name);
                return "game over";
            }
            else return "Fight";



        }
        
        
        //Calculate 1 warriors attach and the others block
        //Subtract block from attacl
        //if there was ad amage subract that from the health
        // printout info on who attacked who and for how much damage
        //Provide output n the change in health
        //Checkk if warriors health fell below 0 and if so print a message and then send a response that will end the loop
        
        
    }
}