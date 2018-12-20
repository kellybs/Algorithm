using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3 };
            int[] b = { 1, 3, 5 };
            int size = a.Length > b.Length ? a.Length : b.Length;
            int valueA = 0;
            int valueB = 0;
            for (int i = 0; i < size; i++)
            {
                int tempA = 1;
                int tempB = 1;
                if (i < a.Length)
                {
                    valueA += tempA << a[i];
                    valueB += tempB << b[i];
                }
                else
                {
                    valueB += tempB << b[i];
                }

            }


            Console.WriteLine(valueA & valueB);

            Console.ReadLine();

        }
    }
}
