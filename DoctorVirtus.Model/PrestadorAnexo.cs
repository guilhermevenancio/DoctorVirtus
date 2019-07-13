using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("PrestadorAnexo")]
public partial class PrestadorAnexo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? PrestadorAnexoID { get; set; }

    public int? PrestadorID { get; set; }

    public DateTime? DataCadastro { get; set; } = DateTime.Now;

    public byte[] Arquivo { get; set; }

    [StringLength(500)]
    public string Observacao { get; set; }
}
