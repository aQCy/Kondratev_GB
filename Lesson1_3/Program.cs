using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumPos = Convert.ToInt32(Console.ReadLine());
            int Fibo = Fibonachi(NumPos);
            Console.WriteLine("{0} элемент числа Фибоначчи равен {1}", NumPos, Fibo);
        }

        //Вариант 1, рекурсивный

        //static int Fibonachi(int ValueInput)
        //{
        //    if (ValueInput == 0 || ValueInput == 1)
        //        return ValueInput;
        //    else
        //    {
        //        return Fibonachi(ValueInput - 1) + Fibonachi(ValueInput - 2);
        //    }
        //}

        //Вариант 2, цикл
        static int Fibonachi(int NumPos)
        {
            int fiboSum = 0;
            int f1 = 0; int f2 = 0;
            if (NumPos == 0)
                return f1;
            else if (NumPos == 1)
                return f1;
            else
            {
                for (int i = 1; i < NumPos; i++)
                {
                    fiboSum = f1 + f2;
                    f1 = f2;
                    f2 = fiboSum;
                }
                return fiboSum;
            }
        }
    }
}