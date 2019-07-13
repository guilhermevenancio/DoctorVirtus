using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Operadora")]
public partial class Operadora
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? OperadoraID { get; set; }

    [StringLength(140)]
    public string Descricao { get; set; }

    public decimal? VersaoXML { get; set; }

    public bool? Ativo { get; set; } = true;
}
