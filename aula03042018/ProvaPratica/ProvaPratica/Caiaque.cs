using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Caiaque : Embarcacao
    {
        public override void locomover()
        {
            Console.WriteLine("O Caiaque está se locomovendo a remo");
        }
        public override void abastecer()
        {
            Console.WriteLine("\nO Caiaque depende da força do remador");
        }

        public override string ToString()
        {
            return "\nInformações do caiaque: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getCorCasco();
        }
    }
}
