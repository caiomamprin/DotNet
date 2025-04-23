using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

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
            var id = Guid.NewGuid().ToString();
            var nome = "Duda";

            _contatos.Adicionar(id, nome);

            Assert.True(true);
        }

        [Test]
        public void ObterContatoTest()
        {
            var id = Guid.NewGuid().ToString();
            var nome = "Duda";
            _contatos.Adicionar(id, nome);
            string nomeResultado = _contatos.ObterContato(id);
            Assert.AreEqual(nome, nomeResultado);

        }

        [TearDown]
        public void TearDown() 
        {
            _contatos = null;
        }

    }
}
