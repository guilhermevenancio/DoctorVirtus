using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ProcedimentoItem")]
public partial class ProcedimentoItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? ProcedimentoItemID { get; set; }

    public int? ProcedimentoID { get; set; }

    [StringLength(80)]
    public string Referencia { get; set; }

    public int? TabelaID { get; set; }

    public decimal? QuantidadeCH_UCO { get; set; } = 0;

    public decimal? QuantidadeFilmeM2 { get; set; } = 0;
    
    public virtual Tabela Tabela { get; set; }
    
}
