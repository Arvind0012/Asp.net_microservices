using Customer.Microservice.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Microservice.DataAccess
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options): base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
