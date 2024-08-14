using Microsoft.EntityFrameworkCore;
using AgendaTelefonicaWeb.Models;

namespace AgendaTelefonicaWeb.Data
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
