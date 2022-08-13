using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraticaProgramacao.src.data;
using PraticaProgramacao.src.modelos;
using System.Linq;

namespace PraticaProgramacaoTest.Test.data
{
    [TestClass]
    public class PraticaProgramacaoContextoTest
    {
        private PraticaProgramacaoContexto _context;

        [TestInitialize]
        public void inicio()
        {
            var opt = new DbContextOptionsBuilder<PraticaProgramacaoContexto>()
                .UseInMemoryDatabase(databaseName: "db_PraticaProgramacao")
                .Options;

            _context = new PraticaProgramacaoContexto(opt);
        }
    
        [TestMethod]
        public void InserirNovoCondominioNoBancoRetornarCondominio()
        {
            CondominioModelo condominio = new CondominioModelo();

            condominio.Nome = "Residencial das flores";
            condominio.Bairro = "Caieiras";


            _context.Condominio.Add(condominio); // Adcionando usuario

            _context.SaveChanges(); // Commita criação

            Assert.IsNotNull(_context.Condominio.FirstOrDefault(u => u.Nome == "Residencial das Flores"));
        }
    }
}
