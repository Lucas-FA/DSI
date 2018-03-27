using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Animal
    {
        private float peso;
        private int idade;
        private int membros;

        public virtual void locomover()
        {
            Console.WriteLine("O animal se locomoveu");
        }
        public void alimentar()
        {
            Console.WriteLine("O animal se alimentou");
        }
        public virtual void emitirSom()
        {
            Console.WriteLine("O animal emitiu som");
        }

        public float getPeso()
        {
            return peso;
        }
        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getMembros()
        {
            return membros;
        }
        public void setMembros(int membros)
        {
            this.membros = membros;
        }

        public override string ToString()
        {
            return "Animal {" + "\nPeso = " + peso + "\nIdade = " + idade + "\nMembros = " + membros + '}';
        }
    }
}
