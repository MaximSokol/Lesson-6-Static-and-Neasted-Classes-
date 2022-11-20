using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__Static_and_Neasted_Classes_.Task_1
{
    static class Calculator
    {
        public static int Add(int a, int b)
        {
            if (a != 0 && b != 0)
                return a + b;
            else
                return 0;
        }
        //-------------------------------------------------

        public static int Sub(int a, int b)
        {
            if (a != 0 && b != 0)
                return a - b;
            else
                return 0;
        }
        //-------------------------------------------------

        public static int Mul(int a, int b)
        {
            if (a != 0 && b != 0)
                return a * b;
            else
                return 0;
        }
        //-------------------------------------------------

        public static int Div(int a, int b)
        {
            if (b == 0)
                return -1;
            else
                return a / b;
        }
        //-------------------------------------------------

        public class ClassInfo
        {
            public void ChoiseIfo(int a, int b)
            {
                Console.Write("Enter the name of an operation ->");
                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "add":
                        Console.WriteLine(Calculator.Add(a, b));
                        break;
                    case "sub":
                        Console.WriteLine(Calculator.Sub(a, b));
                        break;
                    case "mult":
                        Console.WriteLine(Calculator.Mul(a, b));
                        break;
                    case "div":
                        Console.WriteLine(Calculator.Div(a, b));
                        break;
                    default:
                        Console.WriteLine("The command is absent!");
                        break;
                }
            }
            //-------------------------------------------------
        }
    }
}
