using MessageNotifier.Models;
using MessageNotifier.Services;
using System;

namespace MessageNotifier.Devices
{
    internal class Printer
    {
        public Printer(MailService mailService)
        {
            mailService.NewMail += OnNewMailEvent;
        }

        /// <summary>
        /// Метод для обработки получения оповещения от внешней службы рассылки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNewMailEvent(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Получено новое сообщение. Выводим на печать:");
            Console.WriteLine($"Письмо от {e.From} для {e.To}");
            Console.WriteLine(e.Subject);
        }

        /// <summary>
        /// Метод по отписке от события
        /// </summary>
        /// <param name="mailService"></param>
        public void Unregister(MailService mailService)
        {
            if(mailService.NewMail == null)
            // TODO добавить проверку на null
            mailService.NewMail -= OnNewMailEvent;
        }

        //public void Print(string text)
        //{
        //    Console.WriteLine($"Печатаем сообщение на принтере: \r\n{text}\r\n");
        //}
    }
}
