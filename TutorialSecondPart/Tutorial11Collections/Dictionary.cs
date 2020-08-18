using System;
using System.Collections.Generic;

namespace Tutorial11Collections
{
    public class Dictionary
    {
        public static void lookAtDictinary()
        {
            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent ", "Superman");
            superheroes.Add("Bruce Wayne ", "Batman");
            superheroes.Add("Barry West", "Flash");

            superheroes.Remove("Barry West");

            Console.WriteLine("Count : {0}", superheroes.Count);
            Console.WriteLine("Clark Kent : {0}", superheroes.ContainsKey("Clark Kent"));

            superheroes.TryGetValue("Clar Kent", out string test);

            Console.WriteLine($"Clark Kent : {test}");

            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            

        }
    }
}