using System;
using System.Collections;

namespace Tutorial11Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  ArrayList Code
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Bob");
            arrayList.Add(40);

            Console.WriteLine("Count: {0}",arrayList.Count);
            Console.WriteLine($"Count : {arrayList.Count}");
            
            
            ArrayList arrayList2 = new ArrayList();
            arrayList2.AddRange(new object[] {"Mike", "Sally", "Egg"});
            
            arrayList.AddRange(arrayList2);
            
            arrayList2.Sort();
            arrayList2.Reverse();
            arrayList2.Insert(1,"Turkey");

            ArrayList range = arrayList2.GetRange(0, 2);

            foreach (object obj in range)
            {
                Console.WriteLine(obj);
            }
            // arrayList2.RemoveAt(0);
            // arrayList2.RemoveRange(0,2);

            Console.WriteLine($"Turkey Index : {arrayList2.IndexOf("Turkey", 0)}");

            string[] myArray = (string[])arrayList2.ToArray(typeof(string));
            string[] customers = {"Bob", "Sally", "Sue"};
            ArrayList customerArrayList = new ArrayList();
            customerArrayList.AddRange(customers);

            foreach (string s in customerArrayList)
            {
                Console.WriteLine(s);
            }

            Dictionary.lookAtDictinary();     
            
            
            
            
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue L {0}", queue.Contains(1));
            Console.WriteLine("Remove 1 : {0}", queue.Dequeue());
            Console.WriteLine("Peek 1 : {0}", queue.Contains(1));

            object[] numArray = queue.ToArray();

            Console.WriteLine(string.Join(", ", numArray));
            
            
            
            foreach (object obj in queue)
            {
                Console.WriteLine($"Queue : {obj}");
            }

            
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            Console.WriteLine("Peek 1 : {0}",stack.Peek());
            Console.WriteLine("Pop 1 : {0}", stack.Pop());
            Console.WriteLine("Contain 1 : {0}", stack.Contains(1));
            object[] numArray2 = stack.ToArray();
            Console.WriteLine(string.Join(", ", numArray2));
            
            


            foreach (object obj in stack)
            {
                Console.WriteLine($"Stack : {obj}");
            }
            {
                
            }
            
            
            
            

            #endregion
        }
    }
}