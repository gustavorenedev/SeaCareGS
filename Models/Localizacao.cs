using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCare.Models
{
    [Table("TBS_Localizacao")]
    public class Localizacao
    {
        [Key]
        public int LocalizacaoId { get; set; }
        [Required]
        [Column("uf_localizacao")]
        public string UF { get; set; }
        [Required]
        [Column("cidade_localizacao")]
        public string Cidade { get; set; }
        [Required]
        [Column("localidade_localizacao")]
        public string Locality { get; set; }
    }
}
