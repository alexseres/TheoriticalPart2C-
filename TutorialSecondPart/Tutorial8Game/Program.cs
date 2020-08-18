using System;

namespace Tutorial8Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximum", 100, 120, 40);
            Warrior bob = new Warrior("Bob", 100, 120, 40);

            Battle.StartFight(maximus, bob);
            
            Console.ReadLine();
        }
    }
}