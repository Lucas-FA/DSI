using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal0 = new Animal();
            Ave animal1 = new Ave();
            Mamifero animal2 = new Mamifero();
            Reptil animal3 = new Reptil();
            Canguru animal4 = new Canguru();
            Cachorro animal5 = new Cachorro();
            Tartaruga animal6 = new Tartaruga();
            Tucano animal7 = new Tucano();

            animal0.setPeso(30.45f);
            animal0.setIdade(12);
            animal0.setMembros(4);

            animal1.setPeso(1.03f);
            animal1.setIdade(6);
            animal1.setMembros(2);
            animal1.setCorPena("Preta");

            animal2.setPeso(40.29f);
            animal2.setIdade(8);
            animal2.setMembros(4);
            animal2.setCorPelo("Marrom");
            animal2.setRaca("Javali");

            animal3.setPeso(4.71f);
            animal3.setIdade(5);
            animal3.setMembros(0);
            animal3.setCorEscama("Verde");

            animal4.setPeso(89.00f);
            animal4.setIdade(9);
            animal4.setMembros(4);
            animal4.setCorPelo("Marrom");
            animal4.setRaca("Canguru-vermelho");

            animal5.setPeso(20.61f);
            animal5.setIdade(10);
            animal5.setMembros(4);
            animal5.setCorPelo("Preto e Branco");
            animal5.setRaca("Husky Siberiano");

            animal6.setPeso(354.71f);
            animal6.setIdade(5);
            animal6.setMembros(4);
            animal6.setCorEscama("Cinza");
            

            animal7.setPeso(0.532f);
            animal7.setIdade(11);
            animal7.setMembros(2);
            animal7.setCorPena("Preta e Branca");

            Console.WriteLine(animal0.ToString());
            Console.WriteLine(animal1.ToString());
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(animal3.ToString());
            Console.WriteLine(animal4.ToString());
            Console.WriteLine(animal5.ToString());
            Console.WriteLine(animal6.ToString());
            Console.WriteLine(animal7.ToString());
            
            Console.ReadKey();
        }
    }
}
