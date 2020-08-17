using System;
using System.Collections.Generic;
using System.IO;

namespace CircularQueue
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue_Array<string> queue1 = new Queue_Array<string>(10);
            queue1.EnQueue("A");
            queue1.EnQueue("B");
            queue1.EnQueue("C");
            Console.WriteLine(queue1); // C  B  A


            string item;
            if (queue1.DeQueue(out item)) //C
            {
                Console.WriteLine(item);
            }

            if (queue1.DeQueue(out item)) // B
            {
                Console.WriteLine(item);
            }

            queue1.EnQueue("D");
            Console.WriteLine(queue1); // D, A
        }


        static void Main_lists(string[] args)
        {
            //Linked_List<int> lst1 = new Linked_List<int>();
            //lst1.AddFirst(1);
            //lst1.AddLast(2);

            //int cnt;
            //bool ifFloorExists = lst1.GetAt(2, out cnt);
            ////ifFloorExists - true/false
            ////cnt - value of iten at position nm. 2


            //Linked_List<string> lst2 = new Linked_List<string>();
            //lst2.AddFirst("aa");

            Linked_List<double> barsList = new Linked_List<double>();
            Linked_List<char> letters = new Linked_List<char>();

        }

        static void Main_sorts(string[] args)
        {
            int size = 1000000;
            Random r = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(size * 5);
                //  Console.Write($"{arr[i]} ");
            }
            DateTime startTime = DateTime.Now;
            Sorts.QuickSort(arr); //NlonN
            Console.WriteLine("=================================\n");
            Sorts.QuickSort(arr); //N^2
            DateTime endTime = DateTime.Now;
            Console.WriteLine("\n\n");
            TimeSpan delta = endTime.Subtract(startTime);
            Console.WriteLine($"total time {delta.TotalMilliseconds}");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

        }


        
        
    }
}

