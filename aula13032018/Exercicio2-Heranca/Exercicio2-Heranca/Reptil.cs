using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Reptil : Animal
    {
        String corEscama;

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
            return "\n\nRéptil {" + "\nPeso = " + peso + "\nIdade = " + idade + "\nMembros = " + membros + "\nCor da escama = " + corEscama + '}';
        }
    }
}
