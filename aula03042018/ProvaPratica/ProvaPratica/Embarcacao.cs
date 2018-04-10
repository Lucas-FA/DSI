using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Embarcacao : Veiculo
    {
        private String corCasco;

        public String getCorCasco()
        {
            return corCasco;
        }
        public void setCorCasco(String corCasco)
        {
            this.corCasco = corCasco;
        }

        public void ancorar()
        {
            Console.WriteLine("\nA embarcação foi ancorada");
        }

        public override string ToString()
        {
            return "\nInformações da embarcação: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + corCasco;
        }
    }
}
