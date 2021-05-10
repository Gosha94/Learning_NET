using System;
using System.Reflection;

namespace LateDllBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Динамическая загрузка сборки в приложение через статические методы Assembly.LoadFrom() или Assembly.Load()
            Assembly asm = Assembly.LoadFrom("TestBase.dll");
            Console.WriteLine(asm.FullName);
            // Получаем все типы из сборки "TestBase.dll"
            Type[] types = asm.GetTypes();
            
            foreach(Type t in types)
            {
                Console.WriteLine(t.Name);
            }
            Console.ReadLine();
        }
    }
}
