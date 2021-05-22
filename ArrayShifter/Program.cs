using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayShifter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задание в смещении массива влево, т.е. первый элемент перемещаем в конец массива
            Ввод:
            3
            231
            Вывод:
            312             
             */

            //var arrayLength = Convert.ToInt32('3');
            //string inpArr = "3 1 2";
            //var arrayForShift = inpArr
            //                        .Trim()
            //                            .Split(' ')
            //                                .ToList();


            //var tempVal = arrayForShift[0];
            //arrayForShift.RemoveAt(0);
            //arrayForShift.Add(tempVal);

            //arrayForShift.ForEach(x => Console.Write($"{x} "));

            string inpArr = " 3 1 2 ";
            List<int> intArr = new List<int>();

            inpArr
                .Trim()
                    .Split(' ')
                        .ToList().ForEach(x =>
                            {
                                intArr.Add(int.Parse(x));
                            }
                        );

            Console.ReadLine();

            

        }
    }
}
