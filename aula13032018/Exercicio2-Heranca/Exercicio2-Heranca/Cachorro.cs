using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Cachorro : Mamifero
    {
        public override void locomover()
        {
            Console.WriteLine("O cachorro andou");
        }
        public override void emitirSom()
        {
            Console.WriteLine("O cachorro latiu");
        }
        public void enterrarOsso()
        {
            Console.WriteLine("O cachorro enterrou seu osso");
        }
        public void abanarRabo()
        {
            Console.WriteLine("O cachorro abanou seu rabo");
        }
        public String reagir(String atitude = "acariciar")
        {
            if (atitude == "brincar" || atitude == "acariciar")
            {
                Console.WriteLine("Abana o rabo");
            }
            else
                Console.WriteLine("Rosna");
            return atitude;
        }
        public int reagir(int hora = 9, int min = 16)
        {
            if (hora < 12)
            {
                Console.WriteLine("Abana o rabo e late");
            }
            else if (hora >= 18)
            {
                Console.WriteLine("Não liga para o dono");
            }
            else
                Console.WriteLine("Abana o rabo");
            return hora;
        }
        public Boolean reagir(Boolean dono = true)
        {
            if (dono == true)
            {
                Console.WriteLine("Abana o rabo e brinca");
            }
            else
                Console.WriteLine("Avança e rosna");
            return dono;
        }

        public override string ToString()
        {
            return "\n\nCachorro {\nPeso = " + getPeso() + "\nIdade = " + getIdade() + "\nMembros = " + getMembros() + "\nCor do pelo = " + getCorPelo() + "\nRaça = " + getRaca() + '}';
        }
    }
}
