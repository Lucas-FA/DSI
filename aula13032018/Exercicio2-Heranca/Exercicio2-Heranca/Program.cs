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
            Aves animal1 = new Aves();
            Mamifero animal2 = new Mamifero();
            Reptil animal3 = new Reptil();

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
            animal3.setIdade(2);
            animal3.setMembros(0);
            animal3.setCorEscama("Verde");

            Console.WriteLine(animal0.ToString());
            Console.WriteLine(animal1.ToString());
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(animal3.ToString());

            Console.ReadKey();
        }
    }
}
