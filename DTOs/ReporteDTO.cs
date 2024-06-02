using System.ComponentModel.DataAnnotations;

namespace SeaCare.DTOs
{
    public class ReporteDTO
    {
        public string? Nome { get; set; }
        [Required]
        public string Uf { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Localidade { get; set; }
        [Required]
        public string Artefato { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
