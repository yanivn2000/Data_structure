using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Hash_SeparateChaining
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{10 << 1}");

            int size = 100000, n;
            Hash_SeparateChaining<string, int> h = new Hash_SeparateChaining<string, int>(size);
            Random r = new Random();
            int cnt = 0;

            for (int i = 0; i < size; i++)
            {
                try
                {
                    n = r.Next();
                    h.Add( n.ToString(), n);
                }
                catch(ArgumentException)
                {
                    cnt++;
                }
            }
            h.Add( "1", 1);
        }
        
    }
}

