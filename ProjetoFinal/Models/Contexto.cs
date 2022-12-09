using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options) { 

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Veiculo> Veiculo { get; set;}    

    }
}
