using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    public class Aluno
    {
        public Aluno() {
            Console.WriteLine("Aluno Constructor");
        }

        public Aluno(string _nome, int _idade) {
            this.nome = _nome;
            this.idade = _idade;
        }

        //Fields
        private string nome;
        private int idade;

        //Properties
        public string Nome
        {
            get {
                return nome;
            }
            set {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if(value >= 18)
                    idade = value;
            }
        }

        public int GetTwiceIdade() {
            int twice = this.idade * 2;
            return twice;
        }

        public bool VerifyMajor(int _idade)
        {
            /*bool verify = false;
            if(_idade >= 18)
                verify = true;
            else
                verify = false;*/

            bool verify = (_idade >= 18) ? true : false; 

            return verify;
        }

        public void Limpar() {
            this.idade = 0;
            this.nome = string.Empty;
        }

        private void GoAge() {
            this.idade = 21;
        }

        ~Aluno() {
            Console.WriteLine("Aluno Destructor");
        }
    }
}
