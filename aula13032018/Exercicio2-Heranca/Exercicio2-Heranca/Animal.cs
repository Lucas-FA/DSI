using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2
{
    class Animal
    {
        public float peso;
        public int idade;
        public int membros;

        public virtual string locomover(string str0)
        {
            str0 = "Você se locomoveu";
            return str0;
        }
        public string alimentar(string str1)
        {
            return str1 = "Você se alimentou";
        }
        public string emitirSom(string str2)
        {
            return str2 = "Você emitiu som";
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
