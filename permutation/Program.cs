using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutation
{
    class Program
    {
        static void isPermutation(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Array.Sort(a);
                Array.Sort(b);

                Console.WriteLine(a.SequenceEqual(b) ? "YES" : "NO");
            }
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 3, 7, 0, 7, 3, 5, 2, 1 };
            int[] b = { 7, 3, 1, 2, 5, 0, 5, 2, 1, 3, 7 };

            isPermutation(a, b);

            int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] d = { 6, 5, 4, 3, 2, 0, 11, 10, 9, 8, 7 };

            isPermutation(c, d);


        }
    }
}
