using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, resultado;
            Console.Write("Digite um número: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            c = double.Parse(Console.ReadLine());
            resultado = Math.Pow(a, 2)*5-c/(b-a%4);
            Console.WriteLine("O resultado da expressão A^2*5-C/(B-A%4) é: {0}", resultado);
            Console.ReadKey();
        }
    }
}
