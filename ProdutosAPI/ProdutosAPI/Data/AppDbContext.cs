using API_REST_de_Produtos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_REST_de_Produtos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
