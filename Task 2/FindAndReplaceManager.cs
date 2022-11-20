using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__Static_and_Neasted_Classes_.Task_2
{
    static class FindAndReplaceManager
    {
        public static void FindNext(string next)
        {
            new Book().FindNext(next);
            new Book.Notes().SaveNote();
        }
    }
}
