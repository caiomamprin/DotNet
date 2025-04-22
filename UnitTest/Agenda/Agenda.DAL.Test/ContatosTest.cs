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

        //AdicionarContatoTest

        [Test]
        public void Test() 
        { 
            //monta
            string id = Guid.NewGuid().ToString();
            string nome = "Duda";
            //executa
            _contatos.Adicionar(id, nome);
            //verifica
            Assert.True(true);
                 }

        [TearDown]
        public void TearDown() 
        {
            _contatos = null;
        }
    }
}
