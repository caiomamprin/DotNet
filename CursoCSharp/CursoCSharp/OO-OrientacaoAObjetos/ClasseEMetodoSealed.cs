using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO_OrientacaoAObjetos
{
    class ClasseEMetodoSealed
    {

        sealed class SemFilho
        {
            public double ValorFortuna = 1_584_145_33;
        }

        //COM O SEALED NAO É POSSÍVEL HERDAR
        //public class FalsoHerdeiro : SemFilho
        //{

        //}

        public class Avo
        {
            public virtual bool HonrarFamilia()
            {
                return false;
            }

            public class Pai : Avo
            {
                public sealed override bool HonrarFamilia()
                {
                    return true;
                }
            }

            public class Filho : Pai
            {
                //COM O SEALED NÃO É POSSIVEL REESCREVER
                //public sealed override bool HonrarFamilia()
                //{
                //    return false;
                //}
            }

        }

        
        public static void Executar()
        {

        }
    }
}
