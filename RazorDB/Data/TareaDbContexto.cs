using Microsoft.EntityFrameworkCore;
using RazorDB.Models;

namespace RazorDB.Data
{
    public class TareaDbContexto : DbContext
    {
        public TareaDbContexto(DbContextOptions <TareaDbContexto> options) : base(options)
        {

        }
        public DbSet<Tarea> Tareas { get; set; }
        protected TareaDbContexto()
        {

        }
    }
}
