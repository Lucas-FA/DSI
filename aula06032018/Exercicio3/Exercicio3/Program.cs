using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double num1, num2;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            num1 = num;
            num2 = Math.Pow(num1, 2);
            Console.WriteLine("O resultado de {0} ao quadrado é: {1}", num, num2);
            Console.ReadKey();
        }
    }
}
