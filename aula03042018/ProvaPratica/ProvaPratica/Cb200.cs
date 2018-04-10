using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Cb200 : Motocicleta
    {
        public override void locomover()
        {
            Console.WriteLine("O Cb200 está se locomovendo com tração roda traseira");
        }
        public override void abastecer()
        {
            Console.WriteLine("\nO Cb200 foi abastecido com álcool");
        }

        public override string ToString()
        {
            return "Informações da Cb200: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getCorMotocicleta();
        }
    }
}
