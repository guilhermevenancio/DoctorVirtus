using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Models
{
    public class _ContextoBase : DbContext {
        
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<AgendaAnexo> AgendaAnexo { get; set; }
        public virtual DbSet<AgendaProcedimento> AgendaProcedimento { get; set; }
        //public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Imposto> Imposto { get; set; }
        public virtual DbSet<LocalAtendimento> LocalAtendimento { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Negociacao> Negociacao { get; set; }
        public virtual DbSet<Operadora> Operadora { get; set; }
        public virtual DbSet<Prestador> Prestador { get; set; }
        public virtual DbSet<PrestadorAnexo> PrestadorAnexo { get; set; }
        public virtual DbSet<Procedimento> Procedimento { get; set; }
        public virtual DbSet<ProcedimentoItem> ProcedimentoItem { get; set; }
        //public virtual DbSet<ProcedimentoGrupo> ProcedimentoGrupo { get; set; }
        public virtual DbSet<Tabela> Tabela { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioGrupo> UsuarioGrupo { get; set; }

    }
}
