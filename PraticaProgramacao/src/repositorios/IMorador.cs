using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;

namespace PraticaProgramacao.src.repositorios
{
    public interface IMorador
    {
        void NovoMorador(NovoMoradorDTO Morador);
        void AtualizarMorador(AtualizarMoradorDTO Morador);
        void DeletarMorador(int id);
        MoradorModelo PegarPeloId(int id);
        MoradorModelo PegarPeloNome(string nome);
    }
}
