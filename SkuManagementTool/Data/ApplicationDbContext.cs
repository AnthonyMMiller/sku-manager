using Microsoft.EntityFrameworkCore;
using SkuManagementTool.Models;

namespace SkuManagementTool.Data
{
    /// Database context for the application.
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /// DbSet representing the SKUs table in the database.
        public DbSet<Sku> Skus { get; set; }
    }
}
