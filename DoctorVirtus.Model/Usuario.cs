using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Usuario")]
public class Usuario
{
    public Usuario()
    {
        Prestador = new HashSet<Prestador>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? UsuarioID { get; set; }

    [MaxLength(30)]
    public string Login { get; set; }

    [MaxLength(15)]
    public string Senha { get; set; }

    [MaxLength(30)]
    public string Nome { get; set; }

    public bool? AcessaAplicativo { get; set; } = true;

    public bool? AcessaSistema { get; set; } = false;

    public int? UsuarioGrupoID { get; set; }

    [MaxLength(200)]
    public string SMTP_Servidor { get; set; }

    public int? SMTP_Porta { get; set; }

    [MaxLength(300)]
    public string SMTP_Usuario { get; set; }

    [MaxLength(60)]
    public string SMTP_Senha { get; set; }

    public bool? SMTP_SSL { get; set; } = false;

    public bool? SMTP_TLS { get; set; } = false;

    public bool Expirado { get; set; } = false;

    public bool? Ativo { get; set; } = true;

    public virtual ICollection<Prestador> Prestador { get; set; }

    public virtual UsuarioGrupo UsuarioGrupo { get; set; }
}
