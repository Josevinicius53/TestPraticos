using Microsoft.EntityFrameworkCore;
using PraticaProgramacao.src.modelos;

namespace PraticaProgramacao.src.data
{
    /// <summary>
    /// <para>Resumo: Classe contexto, responsavel por carregar contexto e definir DbSets</para>
    /// <para>Criado por: Jose Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/07/2022</para>
    /// </summary>
    public class PraticaProgramacaoContexto : DbContext
    {
        public DbSet<CondominioModelo> Condominio { get; set; }
       
        public DbSet<MoradorModelo> Morador { get; set; }

        public DbSet<FamiliaModelo> Familia { get; set; }
        public PraticaProgramacaoContexto(DbContextOptions<PraticaProgramacaoContexto> opt) : base(opt) { }
    }
}
