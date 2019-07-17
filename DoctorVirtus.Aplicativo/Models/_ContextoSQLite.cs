using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Models {

    public class _ContextoSQLite : _ContextoBase {
        
        private string _databasePath;

        public _ContextoSQLite() {
            _databasePath = App.dbPath;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}