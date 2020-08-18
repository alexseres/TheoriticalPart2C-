using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Channels;

namespace Tutorial12Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Animal(){Name = "Doug"});
            animalList.Add(new Animal(){Name = "Paul"});
            animalList.Add(new Animal(){Name = "Sally"});
            animalList.Insert(1, new Animal(){Name = "Steve"});
            animalList.RemoveAt(1);

            Console.WriteLine("Num of animals : {0} ", animalList.Count);

            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Name);
            }

            int x = 5, y = 4;
            Animal.GetSum(ref x, ref y);

            string stringX = "5", stringY = "4";
            Animal.GetSum(ref stringX, ref stringY);
            
            
            
            
            
            Rectangle<int>rectangle1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rectangle1.GetArea());
            Rectangle<string>rectangle2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rectangle1.GetArea());

            Arithmetic add, sub, addSub;
            
            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;
            sub = addSub - add;

            Console.WriteLine($"Add 6 & 10");
            add(6, 10);

            Console.WriteLine("Add & Sub 10 & 4");
            addSub(10, 4);


        }

        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public T Width
            {
                get { return width;}
                set
                {
                    width = value;
                }
            }
            public T Length
            {
                get { return length;}
                set { length = value;}
            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double doubleWidth = Convert.ToDouble(Width);
                double doubleLength = Convert.ToDouble(Length);
                return string.Format($"{Width} * {Length} = {doubleWidth * doubleLength}");
            }
            
            
            
        }
        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        
        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}