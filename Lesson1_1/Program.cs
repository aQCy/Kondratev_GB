using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_1
{
    class Program
    {
        public static bool NumberCheck(int n)
        {
            int d = 0; int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    break; //Нет необходимости проверять после того как нашли такое число i, которое делит число n нацело, так как по условию мы никогда не придем к i==n
                }
                else
                    i++;
            }
            if (d == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool Check = NumberCheck(n);
            if (Check)
                Console.WriteLine("Число простое");
            else
                Console.WriteLine("Число не простое");
        }
    }
}
