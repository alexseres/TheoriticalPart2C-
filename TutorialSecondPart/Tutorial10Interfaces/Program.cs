using System;

namespace Tutorial10Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
         Vehicle buick = new Vehicle("Buick", 4, 160);
         if (buick is IDrivable)
         {
             buick.Move();
             buick.Stop();
         }
         else
         {
             Console.WriteLine($"The{buick.Brand} cant be driven");
         }

         IElectronicDevice TV = TvRemote.GetDevice();
         PowerButton powBut = new PowerButton(TV);
         powBut.Execute();
         powBut.Undo();

         Console.ReadLine();


        }
    }
}