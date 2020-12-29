using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Lesson5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo[] TaskList = new ToDo[10];
            string curFile = @"TaskList.json";
            if (File.Exists(curFile))
            {
                string JsonRead = File.ReadAllText("TaskList.json");
                TaskList = JsonSerializer.Deserialize<ToDo[]>(JsonRead);
            }

            for (int i = 0; i < TaskList.Length; i++)
            {
                if (TaskList[i] == null)
                {
                    TaskList[i] = new ToDo("0", false, i + 1);
                }
            }
            bool CheckingEmptyTasks=false;
            Console.Write("Хотите добавить новое задание? Напишите Y или N: ");
            string Check = Console.ReadLine();
            if (Check == "Y"|| Check == "y")
            {
                for (int i = 0; i < TaskList.Length; i++)
                {
                    if (TaskList[i].Title == "0")
                    {
                        CheckingEmptyTasks = true;
                    }
                }
                if (CheckingEmptyTasks)
                {
                    for (int i = 0; i < TaskList.Length; i++)
                    {
                        if (TaskList[i].Title == "0")
                        {
                            Console.Write("Напишите задание:");
                            string Quest = Console.ReadLine();
                            TaskList[i].Title = Quest;
                            Console.Write("Хотите добавить еще одно задание? Напишите Y или N: ");
                            Check = Console.ReadLine();
                            if (Check == "N"|| Check == "n") { break; }

                        }
                    }
                }
                else
                    Console.WriteLine("Свободных мест для заданий нет! ");
            }
            for (int i = 0; i < TaskList.Length; i++)
            {
                if (TaskList[i].Title != "0")
                    if (TaskList[i].IsDone)
                    {
                        Console.Write("Задание {0} : {1}   , Выполнено: X", TaskList[i].Index, TaskList[i].Title);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Задание {0} : {1}   , Выполнено: ", TaskList[i].Index, TaskList[i].Title);
                        Console.WriteLine();
                    }

            }
            Console.Write("Хотите удалить задание? Напишите Y или N: ");
            Check = Console.ReadLine();
            if (Check == "Y"|| Check == "y")
            { 
                Console.Write("Введите порядковый номер задания чтобы завершить его: ");
                String IndexInput = Console.ReadLine();
                int TaskIsDone = Int32.Parse(IndexInput);
                for (int i = 0; i < TaskList.Length; i++)
                    {
                     if (TaskList[i].Index == TaskIsDone) { TaskList[i].IsDone = true; }
                    }
            }
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            string json = JsonSerializer.Serialize(TaskList, options);
            File.WriteAllText("TaskList.json", json);
        }
    }
}
