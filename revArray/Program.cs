using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace revArray
{
    class Program
    {
        static int[] reverseArray(int N, int[] arr)
        {
            int start = 0;
            while (start < N - 1)
            {
                int temp = arr[start];
                arr[start] = arr[N - 1];
                arr[N - 1] = temp;
                start++;
                N--;
            }
            return arr;
        }
        static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] N = { 3, 4 };
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 1, 2, 1, 0 } };

            printArray(reverseArray(N[0], arr[0]));
            printArray(reverseArray(N[1], arr[1]));
        }
    }
}