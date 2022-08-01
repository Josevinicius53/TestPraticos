using System.ComponentModel.DataAnnotations;

namespace PraticaProgramacao.src.dtos
{
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
    public class AtualizarCondominioDTO
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(30)]
        public string Bairro { get; set; }

        public AtualizarCondominioDTO(int id, string nome, string bairro)
        {
            Id = id;
            Nome = nome;
            Bairro = bairro;
        }
    }
}
