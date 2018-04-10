using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Motocicleta : Veiculo
    {
        private String corMotocicleta;

        public String getCorMotocicleta()
        {
            return corMotocicleta;
        }
        public void setCorMotocicleta(String corMotocicleta)
        {
            this.corMotocicleta = corMotocicleta;
        }

        public override string ToString()
        {
            return "\nInformações da motocicleta: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + corMotocicleta;
        }
    }
}
