using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num0, num1;
            Console.Write("Digite um número: ");
            num0 = float.Parse(Console.ReadLine());
            num1 = num0 * 2;
            Console.WriteLine("O resultado de {0} * 2 é: {1}", num0, num1);

            Console.ReadKey();
        }
    }
}
