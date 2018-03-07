using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, total;

            a = 20;
            b = 10;

            Console.WriteLine(a + "+" + b + "=" + (a + b));
            total = a - b;
            Console.WriteLine(a + "-" + b + "=" + total);
            Console.WriteLine(a + "*" + b + "=" + (a * b));
            Console.WriteLine(a + "/" + b + "=" + (a / b));
            Console.WriteLine(a + "%" + b + "=" + (a % b));
            Console.ReadKey();
        }
    }
}
