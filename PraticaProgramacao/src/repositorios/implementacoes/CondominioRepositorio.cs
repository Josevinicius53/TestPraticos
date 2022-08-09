    using Microsoft.EntityFrameworkCore;
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
    /// <para>Data: 31/08/2022</para>
    /// </summary>
    public class CondominioRepositorio : ICondominio
    {
        #region Atributos

        private readonly PraticaProgramacaoContexto _context;

        #endregion Atributos


        #region Construtores

        public CondominioRepositorio(PraticaProgramacaoContexto context)
        {
            _context = context;
        }

        #endregion Construtores

        #region Métodos
        public async Task NovoCondominioAsync(NovoCondominioDTO condominio)
        {
            await _context.Condominio.AddAsync(new CondominioModelo
            {
                Nome = condominio.Nome,
                Bairro = condominio.Bairro,
            });
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarCondominioAsync(AtualizarCondominioDTO condominio)
        {
            var condominioModelo = await PegarCondominioPeloIdAsync(condominio.Id);
            condominioModelo.Nome = condominio.Nome;
            condominioModelo.Bairro = condominio.Bairro;
            _context.Condominio.Update(condominioModelo);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarCondominioAsync(int id)
        {
            _context.Condominio.Remove(await PegarCondominioPeloIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<CondominioModelo> PegarCondominioPeloIdAsync(int id)
        {
            return await _context.Condominio
                .FirstOrDefaultAsync(c => c.Id == id);  
        }

        public async Task<List<CondominioModelo>> PegarCondominioPeloNomeAsync(string nome)
        {
            return await _context.Condominio
                .Where(c => c.Nome.Contains(nome))
                .ToListAsync();
        }


        public async Task<CondominioModelo> PegarCondominioPeloBairroAsync(string bairro)
        {
            return await _context.Condominio
                .FirstOrDefaultAsync(c => c.Bairro == bairro);
        }

        #endregion Metódos
    }
}
