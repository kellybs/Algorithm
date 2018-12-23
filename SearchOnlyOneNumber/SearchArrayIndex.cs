using System;

namespace SearchOnlyOneNumber
{
    class SearchArrayIndex
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 在一个已经排序的Int数组中，查找某个number，如果存在这个number，返回在数组的位置，反之返回-1
             * 
             */


            int[] array = { 5, 40, 60, 102, 203 };

            int number = 40;
            int index = GetArrayIndex(array, number);

            Console.WriteLine($"数字：{number}对应的下标：{index}");

            Console.ReadLine();
        }

        /// <summary>
        /// 使用二分法查找
        /// </summary>
        /// <param name="array"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private static int GetArrayIndex(int[] array,int numbers)
        {
            int result = -1;
            if (array == null || array.Length == 0 || numbers < array[0] || numbers > array[array.Length - 1]) return result;

            int low = 0, high = array.Length-1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (array[mid] == numbers)
                {
                    result = mid;
                    break;
                }
                else if (array[mid] > numbers)
                {
                    high = mid-1;
                }
                else if (array[mid] < numbers)
                {
                    low = mid+1;
                }
            }

            return result;
        }
    }
}
