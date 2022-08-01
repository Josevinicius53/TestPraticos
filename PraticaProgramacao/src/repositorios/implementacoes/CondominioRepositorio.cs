using PraticaProgramacao.src.data;
using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.repositorios.implementacoes
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por implementar ICondominio</para>
    /// <para>Criado por: Jose vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 13/05/2022</para>
    /// </summary>
    public class CondominioRepositorio : ICondominio
    {
        #region Atributos

        private readonly PraticaProgramacaoContexto _contexto;

        #endregion Atributos


        #region Construtores

        public CondominioRepositorio(PraticaProgramacaoContexto contexto)
        {
            _contexto = contexto;
        }

        #endregion Construtores
        public async Task AtualizarAsync(AtualizarCondominioDTO Condominio)
        {
            var CondominioExistente = await PegarCondominioPeloIdAsync(Condominio.Id);
            CondominioExistente.Nome = Condominio.Nome;
            CondominioExistente.Bairo = Condominio.Bairro;
            _contexto.Condominio.Update(CondominioExistente);
            await _contexto.SaveChangesAsync();
        }

        public async Task DeletarCondominioAsync(int id)
        {
            _contexto.Condominio.Remove(await PegarCondominioPeloIdAsync(id));
            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para criar um novo Condominio</para>
        /// </summary>
        /// <param name="Condominio">NovoCondominioDTO</param>
        public async Task NovoCondominioAsync(NovoCondominioDTO Condominio)
        {
            await _contexto.Condominio.AddAsync(new CondominioModelo
            {
                Nome = Condominio.Nome,
                Bairro = Condominio.Bairro,
            });

            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar um Condominio pelo bairro</para>
        /// </summary>
        /// <param name="bairro"> Condominio</param>
        /// <return>UsuarioModelo</return>
        public async Task<List<CondominioModelo>> PegarPeloBairroAsync(string bairro)
        {
            return await _contexto.Condominio.PegarPeloBairroAsync(u => u.Bairro == bairro);
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar um Condominio pelo Id</para>
        /// </summary>
        /// <param name="id">Id do condominio</param>
        /// <return>UsuarioModelo</return>
        public async Task<List<CondominioModelo>> PegarPeloIdAsync(int id)
        {
            return await _contexto.Condominio.FirstOrDefaultAsync(u => u.Id == id);
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar Condominio pelo nome</para>
        /// </summary>
        /// <param name="nome">Nome do Condominio</param>
        /// <return>Lista CondominioModelo</return>
        public async Task<List<CondominioModelo>> PegarPeloNomeAsync(string Nome)
        {
            return await _contexto.Condominio
                        .Where(u => u.Nome.Contains(nome))
                        .ToListAsync();
        }
    }
}
