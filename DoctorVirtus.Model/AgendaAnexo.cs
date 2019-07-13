using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("AgendaAnexo")]
public partial class AgendaAnexo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? AgendaAnexoID { get; set; }

    public int? AgendaID { get; set; }

    public DateTime? DataCadastro { get; set; } = DateTime.Now;

    public byte[] Arquivo { get; set; }

    [StringLength(500)]
    public string Observacao { get; set; }
}
