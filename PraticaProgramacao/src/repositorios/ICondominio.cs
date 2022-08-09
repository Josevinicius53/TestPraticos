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
       Task NovoCondominioAsync(NovoCondominioDTO condominio);
       Task AtualizarCondominioAsync(AtualizarCondominioDTO condominio);
       Task DeletarCondominioAsync(int id);
       Task<CondominioModelo> PegarCondominioPeloIdAsync(int id);
       Task<List<CondominioModelo>> PegarCondominioPeloNomeAsync(string nome);
       Task<CondominioModelo> PegarCondominioPeloBairroAsync(string bairro);
    }
}
