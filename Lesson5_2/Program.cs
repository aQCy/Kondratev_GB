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
            string Time = "";
            DateTime Input = DateTime.Now;
            string RandomText = "RandomText.txt";
            File.AppendAllText(RandomText, Input.ToString(Time));
            File.AppendAllText(RandomText, Environment.NewLine);
            string fileText = File.ReadAllText(RandomText);
            Console.WriteLine(fileText);
        }
    }
}
