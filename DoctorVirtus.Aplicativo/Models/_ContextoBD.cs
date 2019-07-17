using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Models
{
    public class _ContextoBD : _ContextoBase
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=doctorvirtus.database.windows.net;Initial Catalog=DoctorVirtus;User ID=user;Password=@Rped94ft;Min Pool Size=3;Max Pool Size=3;Connection Lifetime=0;Connect Timeout=30;Current Language=Portuguese;");
        }

        
    }
}
