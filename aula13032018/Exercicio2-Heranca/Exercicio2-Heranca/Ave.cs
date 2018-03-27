using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Ave : Animal
    {
        private String corPena;

        public override void emitirSom()
        {
            Console.WriteLine("A ave emitiu som");
        }
        public virtual void fazerNinho()
        {
            Console.WriteLine("A ave fez um ninho");
        }

        public String getCorPena()
        {
            return corPena;
        }
        public void setCorPena(String corPena)
        {
            this.corPena = corPena;
        }

        public override string ToString()
        {
            return "\n\nAve {\nPeso = " + getPeso() + "\nIdade = " + getIdade() + "\nMembros = " + getMembros() + "\nCor da pena = " + corPena + '}';
        }
    }
}
