using BulkyWebAppFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebAppFinal.Data
{
    public class ApplicationDbContext: DbContext  
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>option) : base(option) 
        { 

        }
        public DbSet<Category> Categories { get; set; }
    }
}
