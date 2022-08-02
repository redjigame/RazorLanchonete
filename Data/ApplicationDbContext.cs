using Microsoft.EntityFrameworkCore;
using RazorLanchonete.Models;

namespace RazorLanchonete.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<XsaladaOrder> XsaladaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}
