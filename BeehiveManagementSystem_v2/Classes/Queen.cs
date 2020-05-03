using BeehiveManagementSystem_v2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem.Classes
{
    class Queen : Bee
    {
        // Конструктор
        public Queen(Worker[] workers, double weightMg) :base(weightMg)
        {
            this.workers = workers;
        }
        // Массив рабочих является закрытым, так как после раздачи заданий ни один другой класс не должен иметь возможности их менять
        // и даже видеть их, ведь приказы рабочим может отдавать только матка. Значение поля задает конструктор.
        private Worker[] workers;
        private int shiftNumber = 0;
        // Матка сначала пытается дать задание первому рабочему.Если он не умеет делать работу указанного типа, она переходит к следующему.
        // Как только находится пчела, которая в состоянии взять задание, метод возвращает значение true, и цикл завершается.
        public bool AssignWork(string job, int numberOfShifts)
        {
            // Форма вызывает этот метод, который просматривает всех рабочих и вызывает метод DoThisWork() пока не найдет подходящего кандидата
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }
        // Метод WorkTheNextShift() объекта queen заставляет рабочего трудиться следующую смену и добавляет строчку в отчет о проделанной работе.
        public string WorkTheNextShift()
        {
            double honeyConsumed = HoneyConsumptionRate();

            shiftNumber++;
            string report = "Отчет для смены#" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyConsumptionRate();

                if (workers[i].DidYouFinish())
                    report += "Рабочий #" + (i + 1) + " закончил работу\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Рабочий #" + (i + 1) + " не работает\r\n";
                else
                if (workers[i].ShiftsLeft > 0)
                    report += "Рабочий #" + (i + 1) + " выполняет ‘" + workers[i].CurrentJob
                    + "’ еще " + workers[i].ShiftsLeft + " смен\r\n";
                else
                    report += "Рабочий #" + (i + 1) + " закончит ‘"
                    + workers[i].CurrentJob + "’ после этой смены\r\n";                
            }
            report += "Общее потребление меда за смену: " + honeyConsumed + " единиц\r\n";            
            return report;
        }
    }
}
