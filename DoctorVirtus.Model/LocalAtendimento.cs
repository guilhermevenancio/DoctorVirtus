using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("LocalAtendimento")]
public partial class LocalAtendimento
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? LocalAtendimentoID { get; set; }

    public DateTime? DataCadastro { get; set; } = DateTime.Now;

    [StringLength(100)]
    public string RazaoSocial { get; set; }

    [StringLength(60)]
    public string NomeFantasia { get; set; }

    [StringLength(14)]
    public string CNPJ { get; set; }

    [StringLength(11)]
    public string Telefone1 { get; set; }

    [StringLength(11)]
    public string Telefone2 { get; set; }

    [StringLength(11)]
    public string Telefone3 { get; set; }

    [StringLength(200)]
    public string Email { get; set; }

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

    public bool? Ativo { get; set; } = true;

    public virtual Municipio Municipio { get; set; }
}
