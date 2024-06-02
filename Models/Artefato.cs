using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCare.Models
{
    [Table("TBS_Artefato")]
    public class Artefato
    {
        [Key]
        public int ArtefatoId { get; set; }
        [Required]
        [Column("nome_artefato")]
        public string Nome { get; set; }
        [Required]
        [Column("descricao_artefato")]
        public string Descricao { get; set; }
    }
}
