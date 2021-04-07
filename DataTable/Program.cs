using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("CubForecast");
            table.Columns.Add("TestColumn");

            table.Rows.Add(155, 2);
            object value = table.Rows[0]["CubForecast"];
            var valInColumn = Convert.ToInt32(value);
            int i = 0;
            bool result = Convert.ToBoolean(valInColumn);
            Console.WriteLine();
        }
    }
}
