using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchOnlyOneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 数组a[N], 1---N-1 这N-1个数存放在a[N]中，其中某个数重复了1次。写一个函数，找出被重复的数字。
             * 
             */


            int[] array = { 5, 4, 3, 1, 2, 4,6 ,7,9,8};

            SearchNumber(array);

            Console.ReadLine();
        }

        /// <summary>
        /// 采用数学求和法，因为只有一个数字重复一次，而又是连续的，根据累加和原理，对数组的所有项求和，然后减去1---N-1的和，即为所求的重复数
        /// </summary>
        /// <param name="array"></param>
        private static void SearchNumber(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            int size = array.Length;

            Console.Write(sum-size * (size -1) / 2);
        }
    }
}
