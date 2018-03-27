using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Canguru : Mamifero
    {
        public override void locomover()
        {
            Console.WriteLine("O canguru pulou");
        }
        public override void emitirSom()
        {
            Console.WriteLine("O canguru emitiu som");
        }
        public void usarBolsa()
        {
            Console.WriteLine("O canguru usou sua bolsa");
        }

        public override string ToString()
        {
            return "\n\nCanguru {\nPeso = " + getPeso() + "\nIdade = " + getIdade() + "\nMembros = " + getMembros() + "\nCor do pelo = " + getCorPelo() + "\nRaça = " + getRaca() + '}';
        }
    }
}
