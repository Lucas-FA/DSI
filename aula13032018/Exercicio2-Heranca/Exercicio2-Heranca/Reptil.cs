using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Reptil : Animal
    {
        private String corEscama;

        public override void emitirSom()
        {
            Console.WriteLine("O réptil emitiu som");
        }

        public String getCorEscama()
        {
            return corEscama;
        }
        public void setCorEscama(String corEscama)
        {
            this.corEscama = corEscama;
        }

        public override string ToString()
        {
            return "\n\nRéptil {\nPeso = " + getPeso() + "\nIdade = " + getIdade() + "\nMembros = " + getMembros() + "\nCor da escama = " + corEscama + '}';
        }
    }
}
