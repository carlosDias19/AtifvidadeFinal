using DDD.Domain.AtividadeAulaContext;
using DDD.Domain.UserManagementContext;
using Microsoft.EntityFrameworkCore;


namespace DDD.Infra.SQLite
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Atividade.db");
        }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<PontoTuristico> PontoTuristico { get; set; }

    }
}
