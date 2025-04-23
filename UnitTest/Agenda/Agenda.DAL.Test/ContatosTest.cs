using System;
using NUnit.Framework;
using Agenda.Domain;
using System.Linq;


namespace Agenda.DAL.Test
{
    [TestFixture]
    public class ContatosTest
    {
        Contatos _contatos;

        [SetUp]
        public void Setup()
        {
            _contatos = new Contatos();
        }

        [Test]
        public void AdicionarContatoTest() 
        {
            var contato = new Contato()
            {
                Id = Guid.NewGuid(),
                Nome = "Duda"
            };

            _contatos.Adicionar(contato);

            Assert.True(true);
        }

        [Test]
        public void ObterContatoTest()
        {
            Contato contatoResultado;
            var contato = new Contato()
            {
                Id = Guid.NewGuid(),
                Nome = "Duda"
            };

            _contatos.Adicionar(contato);
            contatoResultado = _contatos.Obter(contato.Id);
            
            Assert.AreEqual(contato.Id, contatoResultado.Id);
            Assert.AreEqual(contato.Nome, contatoResultado.Nome);

        }
        [Test]
        public void ObterTodosContatosTest()
        {
            var contato1 = new Contato() { Id = Guid.NewGuid(), Nome = "Duda" };
            var contato2 = new Contato() { Id = Guid.NewGuid(), Nome = "Caio" };

            _contatos.Adicionar(contato1);
            _contatos.Adicionar(contato2);

            var listaContato = _contatos.ObterTodos();
            var contatoResultado = listaContato.Where(o => o.Id == contato1.Id).FirstOrDefault();

            Assert.IsTrue(listaContato.Count() >= 1);
            Assert.AreEqual(contato1.Id, contatoResultado.Id);
            Assert.AreEqual(contato1.Nome, contatoResultado.Nome);
        }

        [TearDown]
        public void TearDown() 
        {
            _contatos = null;
        }

    }
}
