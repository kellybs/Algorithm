using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTwoArraySame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  找出2个有序的数组中重复的数字
             */

            int[] array = new[] {5,8,12,34,56 };

            int[] arraySecond = new[] { 7,9,10,11,12,25,30,35,40,50,56,60};

            GetSameNumber(array, arraySecond);

            Console.ReadLine();

        }

        /// <summary>
        /// 首先设两个下标，分别初始化为两个数组的起始地址，依次向前推进 。
        /// 推进的规则是比较两个数组中的数字，小的那个数组的下标向前推进一步，直到任何一个数组的下标到达数组末尾时，如果这时还没碰到相同的数字，说明数组中没有相同的数字。
        /// </summary>
        /// <param name="array">第一个数组</param>
        /// <param name="arraySecond">第二个数组</param>
        private static void GetSameNumber(int[] array, int[] arraySecond)
        {
            int i=0, j = 0;

            while (i < array.Length && j < arraySecond.Length)
            {
                if (array[i] == arraySecond[j])
                {
                    Console.WriteLine($"{array[i]}");
                    i++;
                    j++;

                }
                else if (array[i] > arraySecond[j])
                {
                    j++;
                }
                else if (array[i] < arraySecond[j])
                {
                    i++;
                }
            }
        }
    }
}
