using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Aeronave : Veiculo
    {
        private String corFuselagem;

        public String getCorFuselagem()
        {
            return corFuselagem;
        }
        public void setCorFuselagem(String corFuselagem)
        {
            this.corFuselagem = corFuselagem;
        }

        public void arremeter()
        {
            Console.WriteLine("\nA aeronave foi arremetada");
        }

        public override string ToString()
        {
            return "\nInformações da aeronave: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + corFuselagem;
        }
    }
}
