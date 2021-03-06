﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ToDoConsolApp.Method;


namespace ToDoConsolApp
{

    class Program
    {
       
        static void Main(string[] args)
        {
        List<TaskModel> tasksModel = new List<TaskModel>();
        string comment = "";
            ConsoleEx.WriteLine("Witam w Managerze Zadań ToDo".PadRight(50, '>').PadLeft(60, '<'), ConsoleColor.Red); //poprawic padleft i right
            ConsoleEx.WriteLine("W razie pomocy wpisz komendę HELP".PadRight(50, '>').PadLeft(60, '<'), ConsoleColor.Blue);
            do
              {
                ConsoleEx.Write("Wpisz komendę: ", ConsoleColor.Blue);
                 
                  comment = Console.ReadLine().ToLower();
                if (Enum.GetNames(typeof(Comments)).Contains(comment))
                {
                    if (comment == Comments.help.ToString())
                    {
                        ConsoleEx.Write("Lista dostępnych komend: ", ConsoleColor.Blue);
                        ConsoleEx.WriteLine(string.Join("; ", Enum.GetNames(typeof(Comments))), ConsoleColor.Yellow);
                    }
                    if (comment == Comments.add.ToString())
                    {
                        AddTask.Add(tasksModel);
                    }
                    if (comment == Comments.clear.ToString())
                    {
                        Console.Clear();
                    }
                    if (comment == Comments.remove.ToString())
                    {
                        RemoveTask.Delete(tasksModel);
                    }
                    if (comment == Comments.load.ToString())
                    {
                        LoaderTasks.Load(tasksModel);
                    }
                    if (comment == Comments.save.ToString())
                    {
                        SaveTasks.Save(tasksModel);
                    }
                    if (comment == Comments.show.ToString())
                    {
                        Show.ShowAll(tasksModel);
                    }
                    Console.WriteLine("hej");
                }
                else
                    Console.WriteLine("Wpisałeś złą komendę");

            } while (comment != "exit");
        }
        

    }

}
