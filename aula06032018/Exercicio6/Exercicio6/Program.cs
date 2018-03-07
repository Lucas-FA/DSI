using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, dolares;
            Console.Write("Digite o valor em reais a ser covertido: ");
            reais = double.Parse(Console.ReadLine());
            dolares = reais*3.20;
            Console.WriteLine("R${0} é igual a ${1}", reais, dolares);
            Console.ReadKey();
        }
    }
}
