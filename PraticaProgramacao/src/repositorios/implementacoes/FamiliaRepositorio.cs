using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.repositorios.implementacoes
{
    public class FamiliaRepositorio : IFamilia
    {
        public Task AtualizarFamiliaAsync(AtualizarFamiliaDTO Familia)
        {
            throw new System.NotImplementedException();
        }

        public Task DeletarFamiliaAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task NovoFamiliaAsync(NovoFamiliaDTO Familia)
        {
            throw new System.NotImplementedException();
        }

        public Task<FamiliaModelo> PegarPeloApto(string apto)
        {
            throw new System.NotImplementedException();
        }

        public Task<FamiliaModelo> PegarPeloId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<FamiliaModelo>> PegarPeloNome(string nome)
        {
            throw new System.NotImplementedException();
        }
    }
}
