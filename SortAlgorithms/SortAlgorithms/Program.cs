using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFuntions
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Solution solution = new Solution();
            int[] nums = new int[] { 1, 9, 8, 5, 7, 6, 0, 3 };

            #region quick sort
            stopwatch.Start();
            solution.QuickSort(nums, 0, nums.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("Sorted array : ");
            foreach (int i in nums)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine(@"
                    
                    Quick sort's runtime is {0}", stopwatch.Elapsed);
            Console.ReadLine();
            #endregion

        }
        public class Solution
        {
            #region quick sort
            public void QuickSort(int[] array, int left, int right)
            {
                if (right <= left)
                {
                    return;
                }

                int temp = 0;
                int pivotIndex = (left + right) / 2;
                int pivot = array[pivotIndex];
                int swapIndex = left;
                array[pivotIndex] = array[right];
                array[right] = pivot;


                for (int i = left; i < right; i++)
                {
                    if (array[i] <= pivot)
                    {
                        temp = array[swapIndex];
                        array[swapIndex] = array[i];
                        array[i] = temp;
                        swapIndex++;
                    }
                }
                array[right] = array[swapIndex];
                array[swapIndex] = pivot;

                QuickSort(array, left, swapIndex - 1);
                QuickSort(array, swapIndex + 1, right);
            }
            #endregion
        }
    }
}
