using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Agenda")]
public class Agenda
{
    public Agenda()
    {
        AgendaProcedimento = new HashSet<AgendaProcedimento>();
        AgendaAnexo = new HashSet<AgendaAnexo>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? AgendaID { get; set; }

    public DateTime? DataCadastro { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string Paciente_Nome { get; set; }

    public int? PrestadorID { get; set; }

    public int? LocalAtendimentoID { get; set; }

    public int? OperadoraID { get; set; }
    
    public DateTime? DataInicial { get; set; } = DateTime.Now;

    public DateTime? DataFinal { get; set; } = DateTime.Now;

    [StringLength(200)]
    public string Observacao { get; set; }

    [StringLength(200)]
    public string NumeroCartao { get; set; }

    [StringLength(200)]
    public string SenhaLiberacao { get; set; }

    public bool? Finalizado { get; set; } = false;

    public virtual Prestador Prestador { get; set; }

    public virtual LocalAtendimento LocalAtendimento { get; set; }

    public virtual Operadora Operadora { get; set; }
    
    public virtual ICollection<AgendaProcedimento> AgendaProcedimento { get; set; }

    public virtual ICollection<AgendaAnexo> AgendaAnexo { get; set; }
}
