using PraticaProgramacao.src.modelos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PraticaProgramacao.src.dtos
{
    public class NovoMoradorDTO
    {
        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Idade { get; set; }

        [ForeignKey("fk_familia")]
        public FamiliaModelo Criador { get; set; }

        public NovoMoradorDTO(string nome, string idade, FamiliaModelo criador)
        {
            Nome = nome;
            Idade = idade;
            Criador = criador;
        }
    }
    public class AtualizarMoradorDTO
    {
        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Idade { get; set; }

        public AtualizarMoradorDTO(string nome, string idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
