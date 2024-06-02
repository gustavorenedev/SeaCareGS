using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCare.Models
{
    [Table("TBS_Reporte")]
    public class Reporte
    {
        [Key]
        public int ReporteId { get; set; }
        [Required]
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        [Required]
        [ForeignKey("LocalizacaoId")]
        public Localizacao Localizacao { get; set; }
        [Required]
        [ForeignKey("ArtefatoId")]
        public Artefato Artefato { get; set; }
        public DateTime ReporteData { get; set; }
    }
}
