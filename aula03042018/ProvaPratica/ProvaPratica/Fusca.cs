using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Fusca : Carro
    {
        public override void locomover()
        {
            Console.WriteLine("O Fusca está se locomovendo com tração 2 rodas");
        }
        public override void abastecer()
        {
            Console.WriteLine("O Fusca foi abastecido com gasolina");
        }

        public override string ToString()
        {
            return "\nInformações do fusca: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getCorCarro();
        }
    }
}
