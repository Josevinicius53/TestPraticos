using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraticaProgramacao.src.data;
using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.repositorios;
using PraticaProgramacao.src.repositorios.implementacoes;
using System.Linq;
using System.Threading.Tasks;

namespace PraticaProgramacaoTest.Test.Repositorio
{
    [TestClass]
    public class CondominioRepositorioTest
    {
        private PraticaProgramacaoContexto _context;
        private ICondominio _repositorio;

        [TestMethod]
        public async Task CriarQuatroCondominioNobancoRetornaQuatroCondominio()
        {
            //Definindo o contexto
            var opt = new DbContextOptionsBuilder<PraticaProgramacaoContexto>()
                 .UseInMemoryDatabase(databaseName: "db_PraticaProgramacao1")
                 .Options;

            _context = new PraticaProgramacaoContexto(opt);
            _repositorio = new CondominioRepositorio(_context);

            await _repositorio.NovoCondominioAsync(
                new NovoCondominioDTO("Jardin das Flores", "Perus"));

            await _repositorio.NovoCondominioAsync(
                new NovoCondominioDTO("Jardin das Flores", "Caieiras"));

            await _repositorio.NovoCondominioAsync(
                new NovoCondominioDTO("Jardin das Flores", "Franco da Rocha"));

            await _repositorio.NovoCondominioAsync(
                new NovoCondominioDTO("Jardin das Flores", "Jundiai"));

            //WHEN - Quando pesquiso lista total            
            //THEN - Então recebo 4 usuarios
            Assert.AreEqual(4, _context.Condominio.Count());
        }

        [TestMethod]
        public async Task PegarCondominioPeloNomeRetornaNaoNulo()
        {
            var opt = new DbContextOptionsBuilder<PraticaProgramacaoContexto>()
                .UseInMemoryDatabase(databaseName: "db_PraticaProgramacao2")
                .Options;

            _context = new PraticaProgramacaoContexto(opt);
            _repositorio = new CondominioRepositorio(_context);

            await _repositorio.NovoCondominioAsync(
                new NovoCondominioDTO("Alpes de Caieiras", "Caieiras"));

            var cond = await _repositorio.PegarCondominioPeloNomeAsync("Caieiras");

            Assert.IsNotNull(cond);
        }

        [TestMethod]
        public async Task PegarCondominioPeloBairroRetornaNaoNulo()
        {
            var opt = new DbContextOptionsBuilder<PraticaProgramacaoContexto>()
                .UseInMemoryDatabase(databaseName: "db_PraticaProgramacao3")
                .Options;

            _context = new PraticaProgramacaoContexto(opt);
            _repositorio = new CondominioRepositorio(_context);

            await _repositorio.NovoCondominioAsync(
                new NovoCondominioDTO("Sitio Aparecisa", "Povilho"));
            var cond = await _repositorio.PegarCondominioPeloBairroAsync("Povilho");
            Assert.IsNotNull(cond);
        }

        [TestMethod]
        public async Task PegarCondominioPeloIdRetornaNaoNuloENomeCondominio()
        {
            var opt = new DbContextOptionsBuilder<PraticaProgramacaoContexto>()
                .UseInMemoryDatabase(databaseName: "db_PraticaProgramacao3")
                .Options;

            _context = new PraticaProgramacaoContexto(opt);
            _repositorio = new CondominioRepositorio(_context);

            await _repositorio.NovoCondominioAsync(
                new NovoCondominioDTO("Parque Suiça", "Caieiras")
                );

            var cond = await _repositorio.PegarCondominioPeloIdAsync(1);
            Assert.AreEqual("Parque Suiça", cond.Nome);
        }
    }
}
