using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Municipio")]
public partial class Municipio
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? MunicipioID { get; set; }

    public int? IBGE { get; set; }

    [StringLength(255)]
    public string Nome { get; set; }

    [StringLength(2)]
    public string UF { get; set; }

    public int? EstadoID { get; set; }
}
