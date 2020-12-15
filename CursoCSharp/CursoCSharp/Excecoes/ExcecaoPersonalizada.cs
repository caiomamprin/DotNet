using System;

namespace CursoCSharp
{
    public class ExcecaoPersonalizada
    {

        public class NegativoException : Exception
        {
            //CONSTRUTOR PADRÃO
            public NegativoException() { }

            public NegativoException (string message) : base(message) { }

            //CONSTRUTOR PARA TRATAR UMA EXCEÇÃO COM PASSANDO OUTRA EXCEÇÃO.
            public NegativoException (string message, Exception inner) : base(message, inner) { }
        }

        public class ImparException : Exception
        {
            public ImparException(string message) : base(message) { }
        }

        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException("Número negativo ... :("); 
            }

            if( valor % 2 == 1)
            {
                throw new ImparException("Número Impar... :(");
            }

            return valor;

        }
        public static void Executar()
        {

            
            
        }
    }
}