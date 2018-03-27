using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Cachorro : Mamifero
    {
        public override void locomover()
        {
            Console.WriteLine("O cachorro andou");
        }
        public override void emitirSom()
        {
            Console.WriteLine("O cachorro latiu");
        }
        public void enterrarOsso()
        {
            Console.WriteLine("O cachorro enterrou seu osso");
        }
        public void abanarRabo()
        {
            Console.WriteLine("O cachorro abanou seu rabo");
        }

        public override string ToString()
        {
            return "\n\nCachorro {\nPeso = " + getPeso() + "\nIdade = " + getIdade() + "\nMembros = " + getMembros() + "\nCor do pelo = " + getCorPelo() + "\nRaça = " + getRaca() + '}';
        }
    }
}
