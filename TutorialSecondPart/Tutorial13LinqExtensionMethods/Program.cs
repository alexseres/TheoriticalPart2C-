using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Tutorial13LinqExtensionMethods
{
    class Program
    {
        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            doubleIt doubleIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {doubleIt(5)}");


            List<int> numList = new List<int> {1, 9, 2, 6, 3};

            var evenList = numList.Where(a => a % 2 == 0).ToList();

            // foreach (var j in evenList)
            // {
            //     Console.WriteLine(j);
            // }

            var rangeList = numList.Where(x => (x > 2 && (x < 9))).ToList();
            foreach(var j in rangeList)
            {
                Console.WriteLine(j);
            }

            List<int> flipList = new List<int>();
            int i = 0;
            Random random = new Random();
            while (i < 100)
            {
                flipList.Add(random.Next(1,3));
                i++;
            }
            Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count);
            Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count);
            var nameList = new List<string> {"Doug", "Sally", "Sue"};
            var sNameList = nameList.Where(x => x.StartsWith("S"));

            foreach (var m in sNameList)
            {
                Console.WriteLine(m);
            }

            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1,10));
            var squares = oneTo10.Select(x => x * x);

            foreach (var l in squares)
            {
                Console.WriteLine(l);
            }

            var listOne = new List<int>(new int[] {1, 3, 4});
            var lisTwo = new List<int>(new int[] {4, 6, 8});
            var sumList = listOne.Zip(lisTwo, (x, y) => x + y).ToList();

            foreach (var n in sumList)
            {
                Console.WriteLine(n);
            }

            var numList2 = new List<int>() {1, 2, 3, 4, 5, 3};
            var numList4 = new List<int>(){3,2};
            Console.WriteLine("Sum : {0}", numList2.Aggregate((a,b) =>a + b));
            Console.WriteLine("Average : {0}", numList2.AsQueryable().Average());
            Console.WriteLine("All > 3 : {0}", numList2.All(x => x > 3));
            Console.WriteLine("Any > 3 : {0}", numList2.Any(x => x > 3));
            Console.WriteLine("Distinct : {0}",string.Join(", ", numList2.Distinct()));
            Console.WriteLine("Except : {0}", string.Join(", ", numList2.Except(numList4)));
        }
}
}