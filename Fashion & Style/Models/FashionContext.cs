using Microsoft.EntityFrameworkCore;

namespace Fashion___Style.Models
{
    public class FashionContext(DbContextOptions<FashionContext> options) : DbContext(options)
    {
        public DbSet<FashionModel> FashionModels { get; set; }
    }
}
