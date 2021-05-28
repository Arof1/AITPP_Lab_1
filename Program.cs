using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, 2, 4, 7, 9, 10, 2, 4 };
            BinarySearch(arr, 5, 0, arr.Length);
        }

        static int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }

            var middle = (first + last) / 2;
            var middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }
    }
}
