using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__Static_and_Neasted_Classes_.Task_2
{
    class Book
    {
        public void FindNext(string next)
        {
            Console.WriteLine($"The string was founded!:\t{next}");
        }
        //-----------------------------------------------------

        internal class Notes
        {
            public void SaveNote()
            {
                Console.WriteLine("The notes was saved!");
            }
            //-----------------------------------------------------
        }
    }
}
