using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Procedimento")]
public partial class Procedimento
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? ProcedimentoID { get; set; }

    [StringLength(80)]
    public string CodigoTUSS { get; set; }

    [StringLength(800)]
    public string Descricao { get; set; }
    
    public bool? Ativo { get; set; } = true;

    public virtual ICollection<ProcedimentoItem> ProcedimentoItem { get; set; }

}
