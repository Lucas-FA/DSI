using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Mamifero : Animal
    {
        private String corPelo;
        private String raca;

        public override void emitirSom()
        {
            Console.WriteLine("O mamífero emitiu som");
        }

        public String getCorPelo()
        {
            return corPelo;
        }
        public void setCorPelo(String corPelo)
        {
            this.corPelo = corPelo;
        }
        public String getRaca()
        {
            return raca;
        }
        public void setRaca(String raca)
        {
            this.raca = raca;
        }

        public override string ToString()
        {
            return "\n\nMamífero {\nPeso = " + getPeso() + "\nIdade = " + getIdade() + "\nMembros = " + getMembros() + "\nCor do pelo = " + corPelo + "\nRaça = " + raca + '}';
        }
    }
}
