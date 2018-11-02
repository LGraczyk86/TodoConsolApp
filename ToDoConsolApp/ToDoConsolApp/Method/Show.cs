using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsolApp.Method
{
    class Show
    {
        //Metoda do wyświtlania wszystkich zadań
        public static void ShowAll(List<TaskModel> lista)
        {
            Print("Opis zadania", "Data Rozpoczęcia", "Data Zakończenia", "Ważność");
            
            foreach (TaskModel task in lista)
            {
                if (!task.FinishDate.HasValue)
                {
                    Print(task.Task, task.StarDate.ToShortDateString(), "Cały dzień", task.FlagImportant);
                }
                else
                {
                    Print(task.Task, task.StarDate.ToShortDateString(), task.FinishDate.Value.ToShortDateString(), task.FlagImportant);
                }
            }
        }

        private static void Print(string description, string startData, string finishData, string important)
        {
            Console.Write(description.PadLeft(30));
            Console.Write("|");
            Console.Write(startData.PadLeft(20));
            Console.Write("|");
            Console.Write(finishData.PadLeft(20));
            Console.Write("|");
            Console.Write(important.PadLeft(10));
            Console.WriteLine("|");
            Console.WriteLine("".PadLeft(84, '-'));
        }
    }
}
