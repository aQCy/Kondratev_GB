using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] PlayField = new bool[10, 10] { { true, false, true, false, true, false, true, false, false, false },{ false, false, false, false, false, false, false, false, false, false },{ true, true, false, true, true, false, true, true, false, false },{ false, false, false, false, false, false, false, false, false, false },{ true, true, true, false, true, true, true, false, false, false },{ false, false, false, false, false, false, false, false, false, false },{ true, true, true, true, false, false, false, false, false, false },{ false, false, false, false, false, false, false, false, false, false },{ false, false, false, false, false, false, false, false, false, false },{ false, false, false, false, false, false, false, false, false, false } };
            string[] str2 = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            Console.WriteLine("   a b c d e f g h i j ");
            for (int i = 0; i < PlayField.GetLength(0); i++)
            {
                if (i < 9)
                {
                    Console.Write(str2[i] + "  ");
                }
                else
                    Console.Write(str2[i]+" ");
                for (int j = 0; j < PlayField.GetLength(1); j++)
                {
                    if (PlayField[i,j]== false)
                        Console.Write("0 ");
                    else
                        Console.Write("X ");
                }
                Console.WriteLine();
            }
        }
    }
}
