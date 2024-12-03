using System.ComponentModel.DataAnnotations;

namespace pratica02.Models
{
    public class Carro {
        public int Id { get; set; }

        [Required(ErrorMessage = "O modelo é obrigatório")]
        [StringLength(100, ErrorMessage = "O modelo deve ter no máximo 100 caracteres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória")]
        [StringLength(50, ErrorMessage = "A marca deve ter no máximo 50 caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O ano é obrigatório")]
        [Range(1900, 2100, ErrorMessage = "Ano inválido")]
        public int Ano { get; set; }
    }
}
