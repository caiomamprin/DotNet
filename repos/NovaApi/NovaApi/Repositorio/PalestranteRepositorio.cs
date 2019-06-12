using NovoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaApi.Repositorio
{
    public class PalestranteRepositorio
    {

        IList<Palestrante> Palestrantes;

        public PalestranteRepositorio()
        {
            Palestrantes = new List<Palestrante>()
            {
                new Palestrante()
                {
                    Id = 1,
                    Nome = "Bill Gates",
                    Email = "tioBill@msft.com",
                    RG = "0101",
                    Skills = new List<string>()
                    {
                        "Copiar Ideias",
                        "C#"
                    }
                },
                 new Palestrante()
                 {
                     Id = 2,
                     Nome = "Joao das Coves",
                     Email = "jcoves@msft.com",
                     RG = "0202",
                     Skills = new List<string>()
                    {
                        "Js",
                        "ReactJs"
                    }
                 }
            };


        }


        public IList<Palestrante> RetornaTudo()
        {
            return Palestrantes;
        }

        public Palestrante RetornaById (int id)
        {
            return Palestrantes.Where(x => x.Id == id).FirstOrDefault();
        }


        public Palestrante AdicionarPalestrante( Palestrante palestrante)
        {
            //simula a inclusão do palestrante na lista 
            palestrante.Id = 3;
            Palestrantes.Add(palestrante);
            return palestrante;
            
        }

        public Palestrante AlteraPalestrante ( Palestrante palestrante)
        {
            //Simula a alteração de um palestrante
            var palestranteOld = this.RetornaById(palestrante.Id);

            //palestranteOld.Id = palestrante.Id;
            palestranteOld.Nome = palestrante.Nome;
            palestranteOld.Email = palestrante.Email;
            palestranteOld.RG = palestrante.RG;
            palestranteOld.Skills = palestrante.Skills;

            //Salva Alterações(caso estivesse usando banco de dados)
            return palestranteOld;

        }

        public IList<Palestrante> ExcluiPalestrante ( int id)
        {
            var palestrante = RetornaTudo().Where(x => x.Id == id).FirstOrDefault();

            Palestrantes.Remove(palestrante);

            return Palestrantes;

        }
    }
}
    
