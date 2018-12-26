using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var val = int.Parse(Console.ReadLine());
            if (val < 1) return;
            string rub = val.ToString(), rubleCase = "рублей";
            char lastChar = ruble[ruble.Length - 1];
            if (ruble.Length >= 2 && ruble[ruble.Length - 2] == '1')
            {
                rubleCase = "рублей";
            }
            else if (lastChar == '1')
            {
                rubleCase = "рубль";
            }
            else if (lastChar == '2' || lastChar == '3' || lastChar == '4')
            {
                rubleCase = "рубля";
            }
            Console.WriteLine("{0} {1}", val, rubleCase);
            Console.ReadKey();
        }
    }
}
