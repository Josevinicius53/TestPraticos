using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;

namespace PraticaProgramacao.src.repositorios
{
    /// <summary>
    /// <para>Resumo:interface Responsavel por representar ações de crud de familia</para>
    /// </summary>
    public interface IFamilia
    {
        void NovoFamilia(NovoFamiliaDTO Familia);
        void AtualizarFamilia(AtualizarFamiliaDTO Familia);
        void Deletar(int id);
        FamiliaModelo PegarPeloId(int id);
        FamiliaModelo PegarPeloNome(string nome);
        FamiliaModelo PegarPeloApto(string apto);
    }
}
