using Crud_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Api.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produtos { get; set;}
    }
}
