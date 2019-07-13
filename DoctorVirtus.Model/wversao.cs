using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("wversao")]
public class wversao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? wversaoID { get; set; }

    [StringLength(15)]
    [Required]
    public string descricao { get; set; }

    [StringLength(5)]
    [Required]
    public string versao { get; set; }
    
}