using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsolApp
{
    public class TaskModel
    {
        private bool _flagImportant = false;
        public string Task { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool FlagaAllDays { get; set; }
        public string FlagImportant
        {
            get
            {
                if (_flagImportant == true)
                {
                    return "Ważne";
                }
                else
                {

                    return "Nie ważne";
                }
               //return _flagImportant;
            }
            set
            {
                if (value == "t")
                {
                    _flagImportant = true;
                }
                else if (value == "n")
                {
                 _flagImportant = false;
                }
                {
                    
                };
            }
        }
        //4 przeciążone konstruktory, w zależności od przyjędtych danych
        public TaskModel(string task, DateTime starDate)
        {
            Task = task;
            StarDate = starDate;
            FinishDate = null;
            FlagaAllDays = true;
        }
        public TaskModel(string task, DateTime starDate, string flagImportant)
        {
            Task = task;
            StarDate = starDate;
            FinishDate = null;
            FlagaAllDays = true;
            FlagImportant = flagImportant;
        }
        public TaskModel(string task, DateTime starDate, DateTime finishDate)
        {
            Task = task;
            StarDate = starDate;
            FinishDate = finishDate;
            FlagaAllDays = false;
        }
        public TaskModel(string task, DateTime starDate, DateTime finishDate, string flagImportant)
        {
            Task = task;
            StarDate = starDate;
            FinishDate = finishDate;
            FlagaAllDays = false;
            FlagImportant = flagImportant;
        }

       
        //private void formatTestOfData()
        //{
        //    DateTime.ParseExact()
        //}
    }
}
