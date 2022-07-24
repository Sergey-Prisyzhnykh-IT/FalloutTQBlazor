using FalloutTQBlazor.GaemsControll.Player;
using FalloutTQBlazor.GaemsControll.TextController;
using Microsoft.EntityFrameworkCore;

namespace FalloutTQBlazor.DateBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<DBTextController> TextControllers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=abul.db.elephantsql.com;Port=5432;Database=pxweigpx;Username=pxweigpx;Password=D0Y_LSEn1QP9qTN1EOKEzIk1TtQ3FLZX");
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FalloutTQ;Username=postgres;Password=12345");
        //}
    }
}
