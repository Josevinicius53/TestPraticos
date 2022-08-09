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
        Task NovoFamiliaAsync(NovoFamiliaDTO familia);
        Task AtualizarFamiliaAsync(AtualizarFamiliaDTO familia);
        Task DeletarFamiliaAsync(int id);
        Task<FamiliaModelo> PegarFamiliaPeloId(int id);
        Task<List<FamiliaModelo>> PegarFamiliaPeloNome(string nome);
        Task<List<FamiliaModelo>> PegarFamiliaPeloApto(string apto);
    }
}
