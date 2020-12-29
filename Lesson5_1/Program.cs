using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            string RandomText = "RandomText.txt";
            File.AppendAllText(RandomText, Input);
            File.AppendAllText(RandomText, Environment.NewLine); 
           // string fileText = File.ReadAllText(RandomText);       Отладка
           //  Console.WriteLine(fileText);

        }
    }
}
