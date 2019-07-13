using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Imposto")]
public partial class Imposto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? ImpostoID { get; set; }

    [StringLength(60)]
    public string Descricao { get; set; }

    public decimal? pAliq_PJ { get; set; } = 0;

    public decimal? pAliq_PF { get; set; } = 0;

    public bool? Ativo { get; set; } = true;
}
