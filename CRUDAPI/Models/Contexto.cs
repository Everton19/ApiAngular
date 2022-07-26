using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }
    }
}