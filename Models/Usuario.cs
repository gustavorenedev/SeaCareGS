using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeaCare.Models
{
    [Table("TBS_Usuario")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Column("nome_usuario")]
        public string? Nome { get; set; }
    }
}
