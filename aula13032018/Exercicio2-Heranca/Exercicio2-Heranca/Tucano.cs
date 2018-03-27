using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Tucano : Ave
    {
        public override void emitirSom()
        {
            Console.WriteLine("O tucano emitiu som");
        }
        public override void fazerNinho()
        {
            Console.WriteLine("O tucano fez um ninho");
        }
        public override void locomover()
        {
            Console.WriteLine("O tucano voou");
        }

        public override string ToString()
        {
            return "\n\nTucano {\nPeso = " + getPeso() + "\nIdade = " + getIdade() + "\nMembros = " + getMembros() + "\nCor da pena = " + getCorPena() + '}';
        }
    }
}
