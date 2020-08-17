using System;
using System.Collections.Generic;
using System.Text;

namespace Recursions
{
    class Recursions
    {
        public static int SumOfValue(int num)
        {
            if (num == 1) return 1;
            return SumOfValue(num - 1) + num;
        }
    }
}
