using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("AgendaProcedimento")]
public partial class AgendaProcedimento
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? AgendaProcedimentoID { get; set; }

    public int? AgendaID { get; set; }

    public int? ProcedimentoID { get; set; }

    public decimal? Valor { get; set; } = 0;

    public virtual Procedimento Procedimento { get; set; }

    [NotMapped]
    public string ItemDescricao {
        get {
            return Procedimento.CodigoTUSS + " - " + Procedimento.Descricao;
        }
    }
}
