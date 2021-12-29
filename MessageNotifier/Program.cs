using MessageNotifier.Devices;
using MessageNotifier.Models;
using MessageNotifier.Services;
using System;

namespace MessageNotifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // обязательно отписывайтесь от событий в методах Dispose, т.к. GC не очистит ссылки, если будет хотя бы один подписчик

            var mailService = new MailService();
            mailService.NewMail += MailServiceNewMail;

            var messenger = new Messenger();
            mailService.NewMail += messenger.MailServNewMail;


            Console.WriteLine("Введите Ваше имя: ");
            var sender = Console.ReadLine();
            
            Console.WriteLine("Введите имя контакта: ");
            var to = Console.ReadLine();
            
            Console.WriteLine("Введите текст сообщения: ");
            var subject = Console.ReadLine();

            mailService.SimulateNewMail(sender, to, subject);
            Console.ReadLine();
        }

        private static void MailServiceNewMail(object sender, NewMailEventArgs e)
        {
            var printer = new Printer();
            printer.Print($"Сообщение от {e.From} для {e.To}. \r\n{e.Subject}");


        }

    }
}
