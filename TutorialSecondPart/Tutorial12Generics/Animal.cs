using System;

namespace Tutorial12Generics
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name = "No name")
        {
            Name = name;
        }


        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double doubleX = Convert.ToDouble(num1);
            double doubleY = Convert.ToDouble(num2);
            Console.WriteLine($"{doubleX} + {doubleY} ={doubleX +doubleY} ");
            
            
        }

       

    }
}