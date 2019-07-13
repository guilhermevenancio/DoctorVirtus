using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Tabela")]
public partial class Tabela
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? TabelaID { get; set; }

    [StringLength(80)]
    public string Descricao { get; set; }

    public decimal? ValorCH_UCO { get; set; } = 0;

    public bool? Ativo { get; set; } = true;
}
