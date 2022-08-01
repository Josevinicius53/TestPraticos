using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.repositorios
{
    /// <summary>
    /// <para>Resumo:interface Responsavel por representar ações de crud de familia</para>
    /// </summary>
    public interface IFamilia
    {
        Task NovoFamiliaAsync(NovoFamiliaDTO Familia);
        Task AtualizarFamiliaAsync(AtualizarFamiliaDTO Familia);
        Task DeletarFamiliaAsync(int id);
        Task<FamiliaModelo> PegarPeloId(int id);
        Task<List<FamiliaModelo>> PegarPeloNome(string nome);
        Task<FamiliaModelo> PegarPeloApto(string apto);
    }
}
