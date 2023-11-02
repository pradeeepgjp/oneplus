using Microsoft.EntityFrameworkCore;
using oneplus.Models;

namespace oneplus.Data
{
    public class IyalDbContext : DbContext
    {
        public IyalDbContext(DbContextOptions<IyalDbContext> options)
            : base(options)
        {
        }


        public DbSet<Iyal> IyalList { get; set; } = default!;

    }
}
