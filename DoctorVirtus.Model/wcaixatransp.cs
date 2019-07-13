using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("wcaixatransp")]
public class wcaixatransp
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int wcaixatranspID { get; set; }

    public int transacao { get; set; }

    public int codemp { get; set; }

    public DateTime dtlan { get; set; }

    [StringLength(10)]
    public string num_doc { get; set; }

    [StringLength(1)]
    public string dc { get; set; }

    public decimal valor { get; set; }

    public int codskill { get; set; }

    public int contrapart { get; set; }

    public int codhist { get; set; }

    [StringLength(40)]
    public string historico { get; set; }

}