using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Negociacao")]
public partial class Negociacao
{
    public Negociacao()
    {
        Imposto = new HashSet<Imposto>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? NegociacaoID { get; set; }

    public int? PrestadorID { get; set; }

    public int? LocalAtendimentoID { get; set; }

    public int? OperadoraID { get; set; }

    public int? TabelaID { get; set; }

    public decimal? ValorCH_UCO { get; set; } = 0;

    public decimal? ValorFilmeM2 { get; set; } = 0;

    public decimal? Deflator { get; set; } = 0;

    public decimal? Acrescimo { get; set; } = 0;

    [StringLength(120)]
    public string Descricao { get; set; }

    public int? DiaFaturamento { get; set; }

    public int? DiaPagamento { get; set; }

    public DateTime? DataVencimento { get; set; }

    public bool? Ativo { get; set; } = true;

    public virtual Prestador Prestador { get; set; }

    public virtual LocalAtendimento LocalAtendimento { get; set; }

    public virtual Operadora Operadora { get; set; }

    public virtual Tabela Tabela { get; set; }

    public virtual ICollection<Imposto> Imposto { get; set; }
}
