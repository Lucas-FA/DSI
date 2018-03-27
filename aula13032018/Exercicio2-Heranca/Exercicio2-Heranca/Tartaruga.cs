using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Tartaruga : Reptil
    {
        public override void locomover()
        {
            Console.WriteLine("A tartaruga andou lentamente");
        }
        public override void emitirSom()
        {
            Console.WriteLine("A tartaruga emitiu som");
        }

        public override string ToString()
        {
            return "\n\nTartaruga {\nPeso = " + getPeso() + "\nIdade = " + getIdade() + "\nMembros = " + getMembros() + "\nCor da escama = " + getCorEscama() + '}';
        }
    }
}
