using Microsoft.EntityFrameworkCore;
using RazorDB.Models;

namespace RazorDB.Data
{
    public class TareaDbContext : DbContext
    {
        
            public TareaDbContext(DbContextOptions<TareaDbContext> options)
                : base(options)
            {
            }

            public DbSet<Tarea> Tareas { get; set; }
        
    }
}
