using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO_OrientacaoAObjetos
{
    class ClasseAbstrata
    {

        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {
                return "Tocando...";
            }
        }

        public class Iphone : Celular
        {
            public override string Assistente()
            {
                return "Olá, sou a Siri...";
            }
        }

        public class Motorola : Celular
        {
            public override string Assistente()
            {
                return "Olá, assistente motorola ativado...";
            }
        }

        public static void Executar()
        {
            Celular c1 = new Iphone();

            c1.Assistente();


            var celulares = new List<Celular>
            {
                new Iphone(),
                new Motorola()
            };

            foreach ( var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }

        }
    }
}
