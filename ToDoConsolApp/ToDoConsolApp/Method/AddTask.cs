using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsolApp.Method
{
    public static class AddTask
    {
        public static void Add(List<TaskModel> tasks)
        {
            ConsoleEx.WriteLine("Dodaj nowe zadanie:", ConsoleColor.Blue);
            ConsoleEx.Write("Podaj opis zadania: ", ConsoleColor.Cyan);
            string newTask = Console.ReadLine();
            string startData = "";
            //todo metoda do sprawdzenia daty
            do
            {
                ConsoleEx.Write("Podaj datę rozpoczęcia: ", ConsoleColor.Cyan);
                startData = Console.ReadLine();

                if (ChecData(startData) == false)
                {
                    Console.WriteLine("Błedny format daty. Dostępny format: dd.mm.yyyy");
                }
                else
                {
                    break;
                }
            } while (true);

            string finishData = "";
            do
            {
                ConsoleEx.Write("Podaj datę zakończenia: ", ConsoleColor.Cyan);
                finishData = Console.ReadLine();
                ConsoleEx.Write("Podaj datę rozpoczęcia: ", ConsoleColor.Cyan);
                startData = Console.ReadLine();

                if (ChecData(startData) == false)
                {
                    Console.WriteLine("Błedny format daty. Dostępny format: dd.mm.yyyy");
                }
                else if (finishData=="")
                {
                    break;
                }
                else
                {
                    break;
                }
            } while (true);

            string flagImportant = "";
            do
            {
                ConsoleEx.Write("Czy zadanie jest ważne [T/N]: ", ConsoleColor.Cyan);
                flagImportant = Console.ReadLine().ToLower();
                if (flagImportant == "t" || flagImportant =="n")
                {
                    break;
                }
                Console.WriteLine("Podałeś zły parametr, popraw się T lub N");
            } while (true);
            

            if (finishData == "")
            {
                if (flagImportant == "t")
                {
                    TaskModel task = new TaskModel(newTask, Convert.ToDateTime(startData), "t");
                    tasks.Add(task);
                }
                else if (flagImportant == "n")
                {
                    TaskModel task = new TaskModel(newTask, Convert.ToDateTime(startData));
                    tasks.Add(task);
                }
            }
            else
            {
                if (flagImportant == "t")
                {
                    TaskModel task = new TaskModel(newTask, Convert.ToDateTime(startData), Convert.ToDateTime(finishData), "t");
                    tasks.Add(task);
                }
                else if (flagImportant == "n")
                {
                    TaskModel task = new TaskModel(newTask, Convert.ToDateTime(startData), Convert.ToDateTime(finishData));
                    tasks.Add(task);
                }
            }
        }

        private static bool ChecData(string data)
        {
            Dictionary<int, int> daysOfMonth = new Dictionary<int, int>
            {
                { 1, 31 },{ 2, 28 },{ 3, 31 },{ 4, 30 },{ 5, 31 },{ 6, 30 },{ 7, 31 },{ 8, 31 },{ 9, 30 },{ 10, 31 },{ 11, 30 },{ 12, 31 }
            };
            Dictionary<int, int> daysOfMonthPlusOne = new Dictionary<int, int> //kalendarz dla roku przestępnego
            {
                { 1, 31 },{ 2, 29 },{ 3, 31 },{ 4, 30 },{ 5, 31 },{ 6, 30 },{ 7, 31 },{ 8, 31 },{ 9, 30 },{ 10, 31 },{ 11, 30 },{ 12, 31 }
            };
            string newData = data.Replace(';', ' ').Replace('-', ' ').Replace('/', ' ').Replace('.', ' ');
            string[] tabData = newData.Split(' ');
            if (tabData.Length !=3)
            {
                return false;
            }
            
                if (int.Parse(tabData[2]) % 4 == 0) //wyliczanie roku przestępnego
                {
                    if (int.Parse(tabData[1]) > 0 && int.Parse(tabData[1]) < 13)
                    {
                        if (int.Parse(tabData[0]) > 0 && int.Parse(tabData[0]) <= daysOfMonthPlusOne[int.Parse(tabData[1])])
                        {
                            new DateTime(int.Parse(tabData[2]), int.Parse(tabData[1]), int.Parse(tabData[0]));

                            return true;
                        }
                    }
                }
                else
                {
                    if (int.Parse(tabData[1]) > 0 && int.Parse(tabData[1]) < 13)
                    {
                        if (int.Parse(tabData[0]) > 0 && int.Parse(tabData[0]) <= daysOfMonth[int.Parse(tabData[1])])
                        {
                            new DateTime(int.Parse(tabData[2]), int.Parse(tabData[1]), int.Parse(tabData[0]));

                            return true;
                        }
                    }
                }
            return false;

        } 
    }
}
