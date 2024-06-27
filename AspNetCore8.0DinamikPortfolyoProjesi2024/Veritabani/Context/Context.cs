using AspNetCore8._0DinamikPortfolyoProjesi2024.Veritabani.Siniflar;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Veritabani.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G942IAR\\SQLEXPRESS;initial Catalog=PortfolioDB;integrated Security=true;TrustServerCertificate=true;");
        }

        public DbSet<Calismalar> Calismalars { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Ekip> Ekips { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}
