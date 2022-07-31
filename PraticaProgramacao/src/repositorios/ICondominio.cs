using PraticaProgramacao.src.dtos;

namespace PraticaProgramacao.src.repositorios
{
    /// <summary>
    /// <para>Resumo:interface Responsavel por representar ações de crud de condominio</para>
    /// </summary>
    public interface ICondominio
    {
        void NovoCondominio(NovoCondominioDTO Condominio);
    }
}
