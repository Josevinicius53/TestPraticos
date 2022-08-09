using System.ComponentModel.DataAnnotations;

namespace PraticaProgramacao.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe espelho para criar um novo Condominio</para>
    /// <para>Criado por: José Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public class NovoCondominioDTO
    {
        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Bairro { get; set; }

        public NovoCondominioDTO(string nome, string bairro)
        {
            Nome = nome;
            Bairro = bairro;
        }
    }

    /// <summary>
    /// <para>Resumo: Classe espelho para Atualizar Condominio</para>
    /// <para>Criado por: José Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public class AtualizarCondominioDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Nome { get; set; }

        [Required]
        public string Bairro { get; set; }

        public AtualizarCondominioDTO(int id, string nome, string bairro)
        {
            Id = id;
            Nome = nome;
            Bairro = bairro;
        }
    }
}
