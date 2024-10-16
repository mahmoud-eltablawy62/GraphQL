using Microsoft.EntityFrameworkCore;
using QraphQl.Test.Models;

namespace QraphQl.Test
{
    public class Bookcontext : DbContext
    {
        public Bookcontext( DbContextOptions<Bookcontext> options ) : base(options)
        {   
        }
        public DbSet<Books> Book { get; set; } 
    }
}
