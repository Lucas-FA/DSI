using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            int idade;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write(nome + ", digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write(nome + ", digite sua cidade: ");
            cidade = Console.ReadLine();
            Console.WriteLine("{0} tem {1} anos de idade e mora em {2}.", nome, idade, cidade);
            Console.ReadKey();

        }
    }
}
