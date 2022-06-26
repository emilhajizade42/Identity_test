using CRUD_pactice_1.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_pactice_1.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Card> Cards { get; set; }
    }
}
