using Microsoft.EntityFrameworkCore;

namespace FinCheck.Models
{
    public class FinchekContext : DbContext
    {

        public FinchekContext( DbContextOptions<FinchekContext> options) : base(options) { 
        
        }


        public DbSet<Transacao> Transacoes { get; set; }

    }
}
