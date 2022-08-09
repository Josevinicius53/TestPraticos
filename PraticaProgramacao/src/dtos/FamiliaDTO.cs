using PraticaProgramacao.src.modelos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PraticaProgramacao.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe espelho para criar uma nova Familia</para>
    /// <para>Criado por: José Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public class NovoFamiliaDTO
    {
        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Apto { get; set; }

        public NovoFamiliaDTO(string nome, string apto)
        {
            Nome = nome;
            Apto = apto;
        }
    }

    /// <summary>
    /// <para>Resumo: Classe espelho para Atualizar a familia </para>
    /// <para>Criado por: José Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public class AtualizarFamiliaDTO
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Apto { get; set; }

        public AtualizarFamiliaDTO(int id, string nome, string apto)
        {
            Id = id;
            Nome = nome;
            Apto = apto;
        }
    }
}
