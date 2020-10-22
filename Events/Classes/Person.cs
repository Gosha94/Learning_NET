using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Classes
{
    class Person
    {
        // Шаблон делегата Action испольщуется когда нет аргументов
        public event Action GoToSleep;
        // Шаблон делегата EventHandler позволяет передавать аргументы
        public event EventHandler DoWork;
        public void TakeTime(DateTime inputDt)
        {
            // Если время меньше 8 часов
            if (inputDt.Hour <= 8)
            {
                // Идти спать
                GoToSleep?.Invoke();
            }
            else
            {
                // Иначе работать
                var args = new EventArgs();
                DoWork?.Invoke(this, args);
            }
        }
    }
}
