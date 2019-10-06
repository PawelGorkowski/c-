using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace existing_powers
{
    class Program
    {
        static int[] getInput()
        {
            var numbers = new List<int>();
            string s;
            while (!string.IsNullOrEmpty(s = Console.ReadLine()))
            {
                numbers.Add(int.Parse(s));
            }

            return numbers.ToArray();
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] x = getInput();

            foreach (int i in x)
            {
                System.Console.Write("{0} ", i);
            }
        }
    }
}
