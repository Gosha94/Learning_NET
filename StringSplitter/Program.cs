using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StringSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Задание в разбиении входной строки - 0102030405 по два символа, и преобразование их в буквы латинского алфавита - abcde                

                В кодировке ASCII символ 'a' имеет код 97, к нему нужно прибавлять элементы
                'z' имеет код - 122
                Всего символов - 26
            */

            string inp = "0102030405060708091011121314151617181920212223242526";
            string pat = "..";

            var matchCollection = Regex.Matches(inp, pat);
            
            var splittedArr = (from Match m in matchCollection select m.Value).ToArray();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var symbolCode in splittedArr)
            {
                var asciiCodeOfChar = Convert.ToByte(symbolCode);
                byte startCharCode = 96;

                if (asciiCodeOfChar <= 0 || asciiCodeOfChar > 26)
                {
                    throw new Exception("Код символа некорректен");
                }

                else
                {
                    byte finalCharCode = (byte)(startCharCode + asciiCodeOfChar);

                    var finalChar = Encoding.ASCII.GetChars(new byte[] { finalCharCode })[0];

                    stringBuilder.Append(finalChar);
                }                
                
            }
            
            Console.WriteLine(stringBuilder);

            Console.ReadLine();
        }
    }
}
