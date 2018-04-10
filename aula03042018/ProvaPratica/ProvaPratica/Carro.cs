using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Carro : Veiculo
    {
        private String corCarro;

        public String getCorCarro()
        {
            return corCarro;
        }
        public void setCorCarro(String corCarro)
        {
            this.corCarro = corCarro;
        }

        public override string ToString()
        {
            return "\nInformações do carro: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + corCarro;
        }
    }
}
