using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.repositorios
{
    /// <summary>
    /// <para>Resumo:interface Responsavel por representar ações de crud de condominio</para>
    /// </summary>
    public interface ICondominio
    {
       Task NovoCondominioAsync(NovoCondominioDTO Condominio);
       Task AtualizarAsync(AtualizarCondominioDTO Condominio);
       Task DeletarCondominioAsync(int id);
       Task<List<CondominioModelo>> PegarPeloIdAsync(int id);
       Task<List<CondominioModelo>> PegarPeloNomeAsync(string Nome);
       Task<List<CondominioModelo>> PegarPeloBairroAsync(string bairro);
    }
}
