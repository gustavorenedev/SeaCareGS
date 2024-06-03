using System.ComponentModel.DataAnnotations;

namespace SeaCare.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class ReporteDTO
    {
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "UF é obrigatório.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "UF deve ter 2 caracteres.")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatória.")]
        [MaxLength(100, ErrorMessage = "Cidade deve ter no máximo 100 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Localidade é obrigatória.")]
        [MaxLength(200, ErrorMessage = "Localidade deve ter no máximo 200 caracteres.")]
        public string Localidade { get; set; }

        [Required(ErrorMessage = "Artefato é obrigatório.")]
        [MaxLength(100, ErrorMessage = "Artefato deve ter no máximo 100 caracteres.")]
        public string Artefato { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatória.")]
        [MaxLength(1000, ErrorMessage = "Descrição deve ter no máximo 1000 caracteres.")]
        public string Descricao { get; set; }
    }

}
