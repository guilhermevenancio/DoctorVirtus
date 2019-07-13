using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("UsuarioGrupo")]
public partial class UsuarioGrupo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? UsuarioGrupoID { get; set; }

    [StringLength(80)]
    public string Descricao { get; set; }

    public bool? Ativo { get; set; } = true;
}
