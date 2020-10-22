using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndAsync
{
    class Program
    {
        static void Main(string[] args)
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
            //Console.WriteLine("Start thread Main");
            //DoWorkAsync();
            

            //int j = 0;
            //for (int i = 0; i < 200; i++)
            //{
            //    j++;
            //    if (j % 10 == 0)
            //    {
            //        Console.WriteLine("MainWork");
            //    }
            //}
            //Console.WriteLine("End thread Main");
            #endregion



            Console.ReadLine();
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
