using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("wcaixabvs")]
public class wcaixabvs
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int wcaixabvsID { get; set; }

    public int codemp { get; set; }

    public DateTime dtlan { get; set; }

    public int seq { get; set; }

    public int codlan { get; set; }

    [StringLength(1)]
    public string dc { get; set; }
    
    public decimal valor { get; set; }

    public int codcon { get; set; }

    [StringLength(10)]
    public string num_doc { get; set; }

    public int codskill { get; set; }

    public int contrapart { get; set; }

    [StringLength(10)]
    public string codcontab { get; set; }

    [StringLength(10)]
    public string historico { get; set; }

    [StringLength(200)]
    public string compl { get; set; }

}