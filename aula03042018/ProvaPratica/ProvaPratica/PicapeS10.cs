using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class PicapeS10 : Carro
    {
        public override void locomover()
        {
            Console.WriteLine("A PicapeS10 está se locomovendo com tração 4 rodas");
        }
        public override void abastecer()
        {
            Console.WriteLine("A PicapeS10 foi abastecido com diesel");
        }

        public override string ToString()
        {
            return "\nInformações da picapeS10: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getCorCarro();
        }
    }
}
