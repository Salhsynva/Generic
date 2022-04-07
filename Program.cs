using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stack
            Stack<int> newStack = new Stack<int>();
            newStack.Push(35);
            newStack.Push(29);
            newStack.Push(312);
            newStack.Push(67);

            Console.WriteLine("peek: " + newStack.Peek());
            Console.WriteLine("Pop: " + newStack.Pop());

            foreach (var item in newStack)
            {
                Console.WriteLine(item);
            }
            int[] stackArr = { 3, 22, 4, 211 };
            Console.WriteLine("==============================");
            Stack<int> stack2 = new Stack<int>(stackArr);
            Console.WriteLine("Number of elements in Stack: " + stack2.Count);
            foreach (var item in stack2)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region queue
            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            queue1.Enqueue(4);
            Console.WriteLine("dequeue: " + queue1.Dequeue());
            Console.WriteLine(queue1.Contains(3));
            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region sortedlist
            SortedList<int, string> myList = new SortedList<int, string>();
            myList.Add(1, "Sona");
            myList.Add(2, "Sugra");
            myList.Add(3, null);

            foreach (KeyValuePair<int, string> kvp in myList)   //anlamadim
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region dictionary
            Console.WriteLine("=======dictionary=======");
            var arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Ayten");
            arrList.Add(" ");
            arrList.Add(true);

            ArrayList arrList2 = new ArrayList(arrList);
            arrList2.Add(23);
            arrList2.Add(45);
            arrList2.Add(27);
            arrList2.Add(89);

            Console.WriteLine("4cu deyer: "+ arrList2[3]);
            arrList2[3] = "Mekteb";
            Console.WriteLine("4cu deyer: " + arrList2[3]);

            foreach (var item in arrList2)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}
