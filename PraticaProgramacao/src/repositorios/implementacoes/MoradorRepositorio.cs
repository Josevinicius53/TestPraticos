using Microsoft.EntityFrameworkCore;
using PraticaProgramacao.src.data;
using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.modelos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.repositorios.implementacoes
{
    public class MoradorRepositorio : IMorador
    {
        private readonly PraticaProgramacaoContexto _context;

        public MoradorRepositorio(PraticaProgramacaoContexto context)
        {
            _context = context;
        }
        public async Task NovoMoradorAsync(NovoMoradorDTO morador)
        {
            await _context.AddAsync(new MoradorModelo
            {
                Nome = morador.Nome,
                Idade = morador.Idade,
            });
        }

        public async Task AtualizarMoradorAsync(AtualizarMoradorDTO morador)
        {
            var moradorModelo = await PegarPeloIdAsync(morador.Id);
            moradorModelo.Idade = morador.Idade;
            moradorModelo.Nome = morador.Nome;
            _context.Morador.Update(moradorModelo);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarMoradorAsync(int id)
        {
            _context.Morador.Remove(await PegarPeloIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<MoradorModelo>> PegarPeloIdadeAsync(string idade)
        {
            return await _context.Morador
                .Where(m => m.Idade.Contains(idade))
                .ToListAsync();
        }

        public async Task<MoradorModelo> PegarPeloIdAsync(int id)
        {
            return await _context.Morador
                .Include(m => m.Familia)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<List<MoradorModelo>> PegarPeloNomeAsync(string nome)
        {
            return await _context.Morador
                .Where(m => m.Nome.Contains(nome))
                .ToListAsync();
        }
    }
}
