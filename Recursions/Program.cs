using System;

namespace Recursions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Recursions.SumOfValue(5));
        }

        static void Main_Sorts(string[] args)
        {
            int size = 1000000;
            Random r = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(size * 5);
               // Console.Write($"{arr[i]} ");
            }
            DateTime startTime = DateTime.Now;
            Sorts.MaxSort(arr);
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
