using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exemplo11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 2;

            Console.WriteLine("Valores de inicialização das variáveis");
            Console.WriteLine("num1 = {0} e num2 = {1}", num1, num2);

            num1 += num2;
            Console.WriteLine();
            Console.WriteLine("Valores após a operação num1 += num2");
            Console.WriteLine("num1 = {0} e num2 = {1}", num1, num2);

            Console.ReadKey();
        }
    }
}
