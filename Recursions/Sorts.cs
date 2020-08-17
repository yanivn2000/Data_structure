using System;
using System.Collections.Generic;
using System.Text;

namespace Recursions
{
    class Sorts
    {
        public static void BubbleSort(int[] a)
        {
            int tmp;
            for (int i = a.Length -1; i > 0; i--)
            {
                for (int j = 0; j < i; j++) //n-1 + n-2 + n-3 + n-4 + .. + 3 + 2 + 1 + 0
                {
                    if(a[j] > a[j+1]) //O(n^2)
                    {
                        tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
        }

        public static void MaxSort(int[] a)
        {
            int maxInd, tmp;

            for (int i = a.Length - 1; i > 0; i--)
            {
                maxInd = 0;
                for (int j = 1; j <= i; j++)//n-1 + n-2 + n-3 +.... + 2 + 1 + 0
                {
                    if (a[j] > a[maxInd]) maxInd = j;  //O(n^2)
                }
                if(maxInd != i)
                {
                    tmp = a[maxInd];
                    a[maxInd] = a[i];
                    a[i] = tmp;
                }
            }
        }
    }
}
