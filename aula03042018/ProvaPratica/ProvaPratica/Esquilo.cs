using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Esquilo : Aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("O esquilo está se locomovendo com hélice");
        }
        public override void abastecer()
        {
            Console.WriteLine("\nO esquilo foi abastecido com diesel");
        }

        public override string ToString()
        {
            return "\nInformações da Esquilo: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getCorFuselagem();
        }
    }
}
