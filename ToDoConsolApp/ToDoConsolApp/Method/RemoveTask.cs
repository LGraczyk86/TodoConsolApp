using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoConsolApp.Method
{
    class RemoveTask
    {
        public static void Delete(List<TaskModel> list)
        {
            ConsoleEx.WriteLine("Usuń zadanie według indeksu poniżej", ConsoleColor.Red);
           
            for (int i = 0; i < list.Count; i++)
            {
             ConsoleEx.WriteLine("".PadLeft(20,'-'), ConsoleColor.Magenta);   
             Console.WriteLine($"{i+1}.: {list.ElementAt(i).Task}");
             ConsoleEx.WriteLine("".PadLeft(20, '-'), ConsoleColor.Magenta);
            }
            
            int id = 0;
            do
            {
                ConsoleEx.Write("Podaj indeks: ", ConsoleColor.Red);
                id =int.Parse(Console.ReadLine());
               
                    if (id > 0 && id <= list.Count)
                    {
                        break;
                    }
                    else
                    {
                        ConsoleEx.WriteLine("Indeks poza zakresem", ConsoleColor.Red);
                    }
            } while (true);

            ConsoleEx.Write("Czy napewno chcesz usunąć zadanie? [T/N]", ConsoleColor.Red);
            
            do
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "t")
                {
                 list.RemoveAt(id-1);
                  ConsoleEx.WriteLine($"Skasowano indeks nr: {id}", ConsoleColor.Yellow);
                    break;
                }
                else if (answer == "n")
                {
                 break;   
                }
                else
                {
                    ConsoleEx.Write("Zły format odpowiedzi!! [T/N]", ConsoleColor.Yellow);
                }
            } while (true);
        }
    }
}
