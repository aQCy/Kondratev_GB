using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите набор чисел от 0 до 255 через пробел:  ");
            string InputText = Console.ReadLine();
            string[] TextSeparated = InputText.Split(' ');
            byte[] bytes = new byte[TextSeparated.Length];
            for (int i = 0; i < TextSeparated.Length; i++)
            {
                bytes[i] = Convert.ToByte(TextSeparated[i]);
            }
            File.WriteAllBytes("bytes.bin", bytes);

        }
    }
}
