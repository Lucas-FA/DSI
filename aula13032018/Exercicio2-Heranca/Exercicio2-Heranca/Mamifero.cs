using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Mamifero : Animal
    {
        String corPelo;
        String raca;

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

        public override string locomover(string str0)
        {
            return str0 = "Você andou";
        }

        public override string ToString()
        {
            return "\n\nMamífero {" + "\nPeso = " + peso + "\nIdade = " + idade + "\nMembros = " + membros + "\nCor do pelo = " + corPelo + "\nRaça = " + raca + '}';
        }
    }
}
