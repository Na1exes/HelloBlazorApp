using Microsoft.EntityFrameworkCore;

namespace HelloBlazorApp.Data
{
    public class PurchaseContext : DbContext
    {
        // DbSet-свойства добавляем после описания наших табличных классов, сейчас не нужно
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<ProposalMaterial> ProposalMaterials { get; set; }

        // Обязательная настройка конструктора. Конфигуратор в Startup’е использует этот конструктор
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString:
               "Server=localhost;Port=5432;User Id=postgres;Database=Blazor;Password=123456;");
            base.OnConfiguring(optionsBuilder);
        }
        // Обязательная настройка конструктора. Конфигуратор в Startup’е использует этот конструктор
        //public PurchaseContext(DbContextOptions<PurchaseContext> options) : base(options)
        //{ }


    }
}
