using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;

namespace PraticaProgramacao.src.repositorios
{
    /// <summary>
    /// <para>Resumo:interface Responsavel por representar ações de crud de condominio</para>
    /// </summary>
    public interface ICondominio
    {
        void NovoCondominio(NovoCondominioDTO Condominio);
        CondominioModelo PegarPeloId(int id);
        CondominioModelo PegarPeloNome(string Nome);
        CondominioModelo PegarPeloBairro(string bairro);
    }
}
