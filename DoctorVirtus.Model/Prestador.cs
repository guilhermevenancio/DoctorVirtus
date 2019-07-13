using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Prestador")]
public partial class Prestador
{
    public Prestador()
    {
        // Municipio = New Municipio
        PrestadorAnexo = new HashSet<PrestadorAnexo>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? PrestadorID { get; set; }

    public DateTime? DataCadastro { get; set; } = DateTime.Now;

    [StringLength(100)]
    public string RazaoSocial { get; set; }

    [StringLength(60)]
    public string NomeFantasia { get; set; }

    [StringLength(14)]
    public string CNPJ { get; set; }

    public int? TipoPessoa { get; set; } = 0;

    public int? UsuarioID { get; set; }

    [StringLength(15)]
    public string InscEstadual { get; set; }

    [StringLength(15)]
    public string InscMunicipal { get; set; }

    [StringLength(11)]
    public string Telefone1 { get; set; }

    [StringLength(11)]
    public string Telefone2 { get; set; }

    [StringLength(11)]
    public string Telefone3 { get; set; }

    [StringLength(200)]
    public string Email { get; set; }

    public DateTime? Abertura { get; set; }

    public short? Sexo { get; set; }

    [StringLength(50)]
    public string NumeroINSS { get; set; }

    [StringLength(50)]
    public string NumeroCRM { get; set; }

    [StringLength(50)]
    public string NumeroCNES { get; set; }

    [StringLength(8)]
    public string CEP { get; set; }

    [StringLength(80)]
    public string Logradouro { get; set; }

    [StringLength(30)]
    public string Numero { get; set; }

    [StringLength(30)]
    public string Complemento { get; set; }

    [StringLength(50)]
    public string Bairro { get; set; }

    public int? MunicipioID { get; set; }

    public bool Ativo { get; set; } = true;

    public virtual Usuario Usuario { get; set; }

    public virtual ICollection<Negociacao> Negociacao { get; set; }

    public virtual ICollection<PrestadorAnexo> PrestadorAnexo { get; set; }

    public virtual Municipio Municipio { get; set; }
}
