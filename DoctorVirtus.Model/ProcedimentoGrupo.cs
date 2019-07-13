using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ProcedimentoGrupo")]
public partial class ProcedimentoGrupo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? ProcedimentoGrupoID { get; set; }

    [StringLength(120)]
    public string Descricao { get; set; }

    public bool? TemCirurgia { get; set; } = false;
}
