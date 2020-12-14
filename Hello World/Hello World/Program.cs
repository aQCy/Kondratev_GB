using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main()
        {
            string UserName = Environment.UserName;
            Console.WriteLine("Привет, {0}, сегодня {1}", UserName, DateTime.Now);
            
        }
    }
}
