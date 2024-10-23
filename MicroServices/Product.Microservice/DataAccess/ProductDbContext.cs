using Microsoft.EntityFrameworkCore;
using Product.Microservice.Models;

namespace Product.Microservice.DataAccess
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options) { }

        public DbSet<Prod> Products { get; set; }
    }
}
