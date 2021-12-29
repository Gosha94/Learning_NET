using MessageNotifier.Models;
using MessageNotifier.Services;
using System;

namespace MessageNotifier.Devices
{
    internal class Messenger
    {
        public void SendSms(string message)
        {
            Console.WriteLine("Просто заглушка");
        }
        
        public void MailServNewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine($"Отправляем SMS для {e.To}: \r\n{e.Subject}\r\n");
        }
    }
}
