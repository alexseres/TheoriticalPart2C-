using System;

namespace Tutorial9AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Circle(5), new Rectangle(4, 5),};

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();

                Console.WriteLine("{0} area : {1:f2} ", shape.Name, shape.Area());

                Circle testCircle = shape as Circle;
                if (testCircle == null)
                {
                    Console.WriteLine("This isnt a Circle");
                }

                if (shape is Circle)
                {
                    Console.WriteLine("This isnt a rectangle");
                }

                

                object circle1 = new Circle(4);
                Circle circle2 = (Circle) circle1;

                Console.WriteLine("The {0} Area is {1:f2}", circle2.Name, circle2.Area());

                Console.WriteLine();
            }
          
        }
    }
}