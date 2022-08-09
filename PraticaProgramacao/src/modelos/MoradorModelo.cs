using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PraticaProgramacao.src.modelos
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por representar tb_morador no banco</para>
    /// <para>Criado por: Jose Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/07/2022</para>
    /// </summary>
    [Table("tb_morador")]
    public class MoradorModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Idade { get; set; }

        [ForeignKey("fk_familia")]
        public FamiliaModelo Familia { get; set;}
    }
}
