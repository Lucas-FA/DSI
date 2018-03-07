using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Lucas", sobrenome = "Freitas", completo;
            completo = nome + " " + sobrenome;

            Console.WriteLine("1) " + nome + sobrenome);
            Console.WriteLine("2) " + completo);
            Console.WriteLine("3) " + nome + " possui " + nome.Length + " caracteres");
            Console.WriteLine("4) " + sobrenome + " possui " + sobrenome.Length + " caracteres");
            Console.WriteLine("5) " + completo + " possui " + completo.Length + " caracteres - incluindo espaço em branco");
            Console.WriteLine("6) " + nome + " em minusculo " + nome.ToLower());
            Console.WriteLine("7) " + nome + " em maiusculo " + nome.ToUpper());
            Console.WriteLine("8) " + nome + " eh igual a " + sobrenome + " = " + nome.Equals(sobrenome));
            Console.WriteLine("9) " + nome + " substring iniciando na posicao 2 e pegando 2 caracteres = " + nome.Substring(2, 2));
            Console.ReadKey();
        }
    }
}
