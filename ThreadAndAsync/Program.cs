using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndAsync
{
    class Program
    {
        // Объект, необходимый для синхронизации потоков
        public static object locker = new object();

        public static int i1 = 100;

        static void M1()
        {
            for (int i = 0; i <= i1; i++)
            {

            }
        }

        static void M2()
        {
            for (int i = 0; i >= i1; i--)
            {

            }
        }


        static async Task Main(string[] args)
        {
            #region SimpleThreading
            //Thread thread = new Thread(new ThreadStart(DoWork));
            //thread.Start();
            //Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            //thread2.Start(500);

            //int j = 0;
            //for (int i = 0; i < 500; i++)
            //{
            //    j++;
            //    if (j % 10 == 0)
            //    {
            //        Console.WriteLine("Main");
            //    }
            //}
            #endregion

            #region Async/Await
            Console.WriteLine("Start thread Main");
            await DoWorkAsync(); //.ContinueWith(a =>int t = 0);


            int j = 0;
            for (int i = 0; i < 200; i++)
            {
                j++;
                if (j % 10 == 0)
                {
                    Console.WriteLine("MainWork");
                }
            }
            Console.WriteLine("End thread Main");
            #endregion

            #region WorkWithConsoleInAsync
            ////var result = SaveFile("d:\\test.txt");
            //var result = SaveFileAsync("d:\\test.txt");
            //var input = Console.ReadLine();
            //Console.WriteLine(result.Result);
            #endregion

            #region Deadlock
            // Deadlock - взаимная блокировка потоками друг друга
            #endregion

            Console.ReadLine();
        }

        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task.Run(() => SaveFile(path));
            return result;
        }

        static bool SaveFile(string path)
        {
            // Участок кода заблокирован от изменения другим потоком
            lock (locker)
            {
                var rnd = new Random();
                var text = "";
                for (int i = 0; i < 50000; i++)
                {
                    text += rnd.Next();
                }
            } // end_lock

            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine();
            }
            return true;
        }

        static async Task DoWorkAsync()
        {
            Console.WriteLine("Created New Thread Async");
            Console.WriteLine("Start Work Async");
            await Task.Run(() => DoWork());
            Console.WriteLine("End Work Async");
        }
        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                j++;
                if (j % 10 == 0)
                {
                    Console.WriteLine("DoWork");
                }
            }
        }
        static void DoWork2(object max)
        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 10 == 0)
                {
                    Console.WriteLine("DoWork_2");
                }
            }
        }
    }
}
