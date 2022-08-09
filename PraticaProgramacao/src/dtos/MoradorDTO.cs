using PraticaProgramacao.src.modelos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PraticaProgramacao.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe espelho para criar um novo Morador</para>
    /// <para>Criado por: José Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public class NovoMoradorDTO
    {
        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Idade { get; set; }

        public NovoMoradorDTO(string nome, string idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    /// <summary>
    /// <para>Resumo: Classe espelho para Atualizar um novo Morador</para>
    /// <para>Criado por: José Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public class AtualizarMoradorDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Idade { get; set; }

        public AtualizarMoradorDTO(string nome, string idade, int id)
        {
            Nome = nome;
            Idade = idade;
            Id = id;
        }
    }
}
