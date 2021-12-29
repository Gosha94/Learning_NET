using System.Linq;
using System.Text.RegularExpressions;

namespace CodeValidator
{
    partial class Program
    {

        //var res1 = ValidateCode("1sdsdsd");
        //var res2 = ValidateCodeWithRegex("1sdsdsd");
        //Console.ReadLine();

        private static bool ValidateCode(string code)
        {
            string[] prefixes = { "1", "2", "3" };
            return prefixes.Any(p => code.StartsWith(p));
        }

        private static bool ValidateCodeWithRegex(string code) => Regex.IsMatch(code, "^(1|2|3)");
    }
}
