using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulamentoOO
{
    public class SubCelebridade
    {
        // TODOS TEM ACESSO
        public string InfoPublico = "Tenho um instagram...";

        // HERANÇA
        protected string corDosOlhos = "Verdes";

        // MESMO PROJETO (ASSEMBLY)
        internal ulong NumeroCelular = 5511984448344;

        // HERANÇA OU MESMO PROJETO
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //MESMA CLASSE OU HERANÇA NO MESMO PROJETO
        private protected string SegredoFamilia = "Bla Bla";

        //private(padrão) só na mesma sCLASSE
        bool UsaMuitoPhotoshop = true;
        
        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublico);
            Console.WriteLine(corDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
