using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_6__Static_and_Neasted_Classes_.Task_1;
using Lesson_6__Static_and_Neasted_Classes_.Task_2;
using Lesson_6__Static_and_Neasted_Classes_.Task_3;

namespace Lesson_6__Static_and_Neasted_Classes_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            //--------------------------------------------------------

            //Calculator.ClassInfo clsInfo = new Calculator.ClassInfo();
            //clsInfo.ChoiseIfo(10, 10);

            //--------------------------------------------------------

            // Task 2

            //--------------------------------------------------------

            //FindAndReplaceManager.FindNext("The next page!");

            //--------------------------------------------------------

            // Task 3

            //--------------------------------------------------------

            //FindAndReplaceManager.FindNext("The next page!");

            //--------------------------------------------------------

            // Task 4

            //--------------------------------------------------------

            int[] arr = { 33, 27, 65, 88, 126 };

            Console.WriteLine("Before!");
            foreach (var elem in arr)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("After!");

            ExpandArray.SortArr(arr);
            foreach(var elem in arr)
            {
                Console.WriteLine(elem);
            }
            //--------------------------------------------------------
        }
    }
}
