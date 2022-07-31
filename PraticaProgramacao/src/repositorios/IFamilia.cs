using PraticaProgramacao.src.dtos;

namespace PraticaProgramacao.src.repositorios
{
    /// <summary>
    /// <para>Resumo:interface Responsavel por representar ações de crud de familia</para>
    /// </summary>
    public interface IFamilia
    {
        void NovoFamilia(NovoFamiliaDTO Familia);
        void AtualizarFamilia(AtualizarFamiliaDTO Familia);
    }
}
