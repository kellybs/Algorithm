using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    /// <summary>
    /// 插入排序
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {          
            int[] array = { 5,15, 99, 14, 34,10,9,100, 66 };
            Console.WriteLine($"排序前的数组：{string.Join(",",array)}");
            Insert(array);
            Console.WriteLine($"排序后的数组：{string.Join(",", array)}");
            Console.ReadLine();
        }

        /// <summary>
        /// 插入排序是简单排序中最快的排序算法，虽然时间复杂度仍然为O(n*n)，但是却比冒泡排序和选择排序快很多
        /// </summary>
        /// <param name="array">需要排序的数组</param>
        private static void Insert(int[] array)
        {
            if (array == null || array.Length == 0) return;
            /*
             *  从第一个元素开始，该元素可以认为已经被排序；
                取出下一个元素，在已经排序的元素序列中从后向前扫描；
                如果该元素（已排序）大于新元素，将该元素移到下一位置；
                重复步骤3，直到找到已排序的元素小于或者等于新元素的位置；
                将新元素插入到该位置后；
                重复步骤2~5。
             */
            int i,j,tmp;
            for (i = 1; i < array.Length; i++)
            {
                tmp = array[i];//本次循环待插入有序列表中的数
                //int index = i - 1;
                //while (index >= 0 && array[index] > tmp)
                //{
                //    array[index + 1] = array[index];
                //    index--;
                //}

                for (j = i - 1; array[j] > tmp && j >= 0; j--)
                {
                    array[j + 1] = array[j];
                }

                array[j + 1] = tmp;
            }
        }
    }
}
