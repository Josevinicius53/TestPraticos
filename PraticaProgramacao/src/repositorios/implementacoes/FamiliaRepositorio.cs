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
    /// <para>Resumo: Classe responsavel por implementar IFamilia</para>
    /// <para>Criado por: Jose vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 31/08/2022</para>
    /// </summary>
    public class FamiliaRepositorio : IFamilia
    {
        private readonly PraticaProgramacaoContexto _context;

        public FamiliaRepositorio(PraticaProgramacaoContexto context)
        {
            _context = context;
        }
        public async Task NovoFamiliaAsync(NovoFamiliaDTO familia)
        {
            await _context.Familia.AddAsync(new FamiliaModelo
            {
                Nome = familia.Nome,
                Apto = familia.Apto
        });
        }
        public async Task AtualizarFamiliaAsync(AtualizarFamiliaDTO familia)
        {
            var familiaModelo = await PegarFamiliaPeloId(familia.Id);
            familiaModelo.Apto = familia.Apto;
            familia.Nome = familia.Nome;
            _context.Familia.Update(familiaModelo);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarFamiliaAsync(int id)
        {
            _context.Familia.Remove(await PegarFamiliaPeloId(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<FamiliaModelo>> PegarFamiliaPeloApto(string apto)
        {
            return await _context.Familia
                 .Where(f => f.Apto.Contains(apto))
                 .ToListAsync();
        }

        public async Task<FamiliaModelo> PegarFamiliaPeloId(int id)
        {
            return await _context.Familia
                .Include(f => f.Criador)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<FamiliaModelo>> PegarFamiliaPeloNome(string nome)
        {
            return await _context.Familia
                .Where(f => f.Nome == (nome))
                .ToListAsync();
        }
    }
}
