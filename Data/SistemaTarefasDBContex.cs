using Microsoft.EntityFrameworkCore;

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefasDBContex : DbContext
    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options) : base(options)
        {
        }

        public DbSet<Models.TarefaModel> Tarefas { get; set; }
        public DbSet<Models.UsuarioModel> Usuarios { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Map.TarefaMap());
            modelBuilder.ApplyConfiguration(new Map.UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
