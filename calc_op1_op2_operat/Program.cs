using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace calc_op1_op2_operat
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите пример с использованием пробелов вида <число1> <число2> <действие>:");
                string[] stnums = Console.ReadLine().Split(' ');
                switch (stnums[2])
                {
                    case "+": Console.WriteLine(double.Parse(stnums[0]) + double.Parse(stnums[1])); break;
                    case "-": Console.WriteLine(double.Parse(stnums[0]) - double.Parse(stnums[1])); break;
                    case "*": Console.WriteLine(double.Parse(stnums[0]) * double.Parse(stnums[1])); break;
                    case "/": Console.WriteLine(double.Parse(stnums[0]) / double.Parse(stnums[1])); break;
                    default: Console.WriteLine("В качестве действия используйте символы '+', '-', '*', '/'"); break;
                }
                Console.ReadLine();
            }
        }
    }
}