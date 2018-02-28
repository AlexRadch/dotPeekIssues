using System;
using System.Collections.Generic;
using System.Linq;

namespace TryCatchThrow
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(RangeRecursive(1, 10).Sum());
            Console.ReadLine();
        }

        static IEnumerable<int> RangeRecursive(int b, int e)
        {
            if (b > e)
                yield break;

            yield return b;

            foreach (var v in RangeRecursive(b + 1, e))
                yield return v;
        }
    }
}
