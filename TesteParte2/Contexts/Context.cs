using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TesteParte2.Domains;

namespace TesteParte2.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Products> Products { get; set; }

        // Construtor que aceita DbContextOptions<Context>
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=SUPORTE\\SQLEXPRESS; Initial Catalog=TesteParte2; User Id=sa; Password=Senai@134; TrustServerCertificate=True;");
            }
        }
    }
}

//optionsBuilder.UseSqlServer("Data Source=SUPORTE\\SQLEXPRESS; DataBase=; User Id=sa; Password=Senai@134; TrustServerCertificate=True;");