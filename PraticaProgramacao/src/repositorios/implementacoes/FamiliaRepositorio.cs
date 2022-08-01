using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.repositorios.implementacoes
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por implementar IFamilia</para>
    /// <para>Criado por: Jose vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 31/08/2022</para>
    /// </summary>
    public class FamiliaRepositorio : IFamilia
    {
        public Task AtualizarFamiliaAsync(AtualizarFamiliaDTO Familia)
        {
            throw new System.NotImplementedException();
        }

        public Task DeletarFamiliaAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task NovoFamiliaAsync(NovoFamiliaDTO Familia)
        {
            throw new System.NotImplementedException();
        }

        public Task<FamiliaModelo> PegarPeloApto(string apto)
        {
            throw new System.NotImplementedException();
        }

        public Task<FamiliaModelo> PegarPeloId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<FamiliaModelo>> PegarPeloNome(string nome)
        {
            throw new System.NotImplementedException();
        }
    }
}
