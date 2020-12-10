using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {

        public string Nome;
        public int Idade;

        //CONSTRUTOR DEFINIDO
        public Pessoa( string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        //CONSTRUTOR PADRÃO 
       public Pessoa()
        {

        }

        public string Apresentar()
        {
            return string.Format($"Ola! Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
