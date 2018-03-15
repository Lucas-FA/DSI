using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Aves : Animal
    {
        String corPena;

        public string fazerNinho(string str3)
        {
            return str3 = "Você fez um ninho";
        }

        public String getCorPena()
        {
            return corPena;
        }
        public void setCorPena(String corPena)
        {
            this.corPena = corPena;
        }

        public override string locomover(string str0)
        {
            str0 = "Você voou";
            return str0;
        }

        public override string ToString()
        {
            return "\n\nAve {" + "\nPeso = " + peso + "\nIdade = " + idade + "\nMembros = " + membros + "\nCor da pena = " + corPena + '}';
        }
    }
}
