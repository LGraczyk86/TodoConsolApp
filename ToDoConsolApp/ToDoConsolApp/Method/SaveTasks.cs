using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsolApp.Method
{
    class SaveTasks
    {
        public static void Save(List<TaskModel> tasks)
        {
            string[] tab = new string[tasks.Count];
            for (int i = 0; i < tasks.Count; i++)
            {
                string newText = "";
                if (tasks.ElementAt(i).FinishDate.HasValue)
                {
                 newText = $"{tasks.ElementAt(i).Task}, {tasks.ElementAt(i).StarDate.ToShortDateString()}, {tasks.ElementAt(i).FinishDate.Value.ToShortDateString()}, {tasks.ElementAt(i).FlagImportant}";
                }
                else
                {
                    //string newFinishData = tasks.ElementAt(i).FinishDate.ToString();

                 newText = $"{tasks.ElementAt(i).Task}, {tasks.ElementAt(i).StarDate.ToShortDateString()}, , {tasks.ElementAt(i).FlagImportant}";
                }

                tab[i] += newText;

            }
            File.WriteAllLines("Data.csv", tab);
            ConsoleEx.WriteLine("Plik został zapisany", ConsoleColor.Yellow);
            Process.Start("Data.csv");
        }
    }
}
