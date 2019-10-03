using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace palindrome
{
    class Program
    {
        static void isPalindrome(string str)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            string newStr = rgx.Replace(str, "");
            newStr = newStr.ToLower();

            Console.WriteLine(newStr.SequenceEqual(newStr.Reverse()) ? "YES" : "NO");
        }


        static void Main(string[] args)
        {
            isPalindrome("abut-1-tuba");
            isPalindrome("@allula");
        }
    }
}
