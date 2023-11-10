using Eshop.Web.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Web.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }


        public DbSet<Product> Products { get; set; }
    }
}
