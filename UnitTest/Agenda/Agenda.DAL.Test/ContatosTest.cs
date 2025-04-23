using System;
using NUnit.Framework;
using Agenda.Domain;


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

        [TearDown]
        public void TearDown() 
        {
            _contatos = null;
        }

    }
}
