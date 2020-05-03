using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem.Classes
{
    class Worker
    {
        private string[] jobsICanDo; // Массив для видов работ пчелы
        // Конструктор
        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo; // Присваиваем полю класса значение параметра переданного в конструктор
        }

        private int shiftsToWork; // Всего смен
        private int shiftsWorked; //  Отработано смен

        // Свойство ShiftsLeft, предназначенное только для чтения показывает, сколько смен осталось отработать до завершения задания
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }
        private string currentJob = "";
        public string CurrentJob        
        {
            get
            {
                return currentJob;
            }
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
                if (jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
    }
}

