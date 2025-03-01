using AzureApi.Model;
using Microsoft.EntityFrameworkCore;

namespace AzureApi.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Loan> Loans { get; set; }
    }
}
