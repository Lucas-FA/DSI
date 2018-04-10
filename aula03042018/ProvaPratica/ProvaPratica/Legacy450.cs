using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPratica
{
    class Legacy450 : Aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("O Legacy450 está se locomovendo com a turbina");
        }
        public override void abastecer()
        {
            Console.WriteLine("O Legacy450 foi abastecido com querosene");
        }

        public String decolar(String clima)
        {
            if (clima == "sol")
            {
                Console.WriteLine("Voo normal");
            }
            else if (clima == "chuva" || clima == "nublado")
            {
                Console.WriteLine("Voo por instrumento");
            }
            else
                Console.WriteLine("Voo cancelado");
            return clima;
        }

        public int decolar(int horario)
        {
            if (horario >= 1 && horario <= 12)
            {
                Console.WriteLine("Altitude mais alta");
            }
            else if (horario > 12 && horario <= 18)
            {
                Console.WriteLine("Altitude média");
            }
            else if (horario > 18 && horario <= 24)
            {
                Console.WriteLine("Altitude baixa");
            }
            else if (horario > 0 && horario < 1)
            {
                Console.WriteLine("Altitude baixa");
            }
            else
                Console.WriteLine("Horário inválido");
            return horario;
        }

        public Boolean decolar(Boolean passageiros)
        {
            if (passageiros == true)
            {
                Console.WriteLine("Servir refeição");
            }
            else
                Console.WriteLine("Amarrar bem a carga");
            return passageiros;
        }

        public override string ToString()
        {
            return "\nInformações da Legacy450: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getCorFuselagem();
        }
    }
}
