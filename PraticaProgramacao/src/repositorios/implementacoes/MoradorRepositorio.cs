using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.repositorios.implementacoes
{
    public class MoradorRepositorio : IMorador
    {
        public Task AtualizarMoradorAsync(AtualizarMoradorDTO Morador)
        {
            throw new System.NotImplementedException();
        }

        public Task DeletarMoradorAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task NovoMoradorAsync(NovoMoradorDTO Morador)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MoradorModelo>> PegarPeloIdadeAsync(string idade)
        {
            throw new System.NotImplementedException();
        }

        public Task<MoradorModelo> PegarPeloIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MoradorModelo>> PegarPeloNomeAsync(string nome)
        {
            throw new System.NotImplementedException();
        }
    }
}
