using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsolApp.Method
{
    class LoaderTasks
    {
        public static void Load(List<TaskModel> tasks)
        {
            tasks = new List<TaskModel>();
            string[] row = File.ReadAllLines("Data.csv");
            for (int i = 0; i < row.Length; i++)
            {
                string[] call = row[i].Split(',');
                string newTask = call[0];
                string startData = call[1];
                string finisgData = call[2];
                string flagImportant;
                if (call[4] == " Ważne")
                {
                    flagImportant = "t";
                }
                else
                {
                    flagImportant = "n";
                }

                bool flagAllDays;
                if (call[2] == " ")
                {
                    flagAllDays = true;
                    TaskModel task = new TaskModel(newTask, Convert.ToDateTime(startData), flagImportant);
                    tasks.Add(task);
                }
                else
                {
                    flagAllDays = false;
                    TaskModel task = new TaskModel(newTask, Convert.ToDateTime(startData), Convert.ToDateTime(finisgData), flagImportant);
                    tasks.Add(task);
                }
            }
            Show.ShowAll(tasks);
        }
    }
}
