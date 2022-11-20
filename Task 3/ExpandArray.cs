using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__Static_and_Neasted_Classes_.Task_3
{
    public static class ExpandArray
    {
        public static void SortArr(this int []arr)
        {
            for (int i = 0; i < arr.Length -1; i++)
            {
                if(arr[i] > arr[i + 1])
                {
                    int tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                }
            }
        }
    }
}
