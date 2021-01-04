using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class Extensionmethods
    {
        public static bool IsOdd(this int i)
        {
            return i % 2 > 0;
        }
    }
}
