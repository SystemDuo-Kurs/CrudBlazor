using CrudBlazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace CrudBlazor.Server
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> o):base(o) { }

        public DbSet<Osoba> Osobas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);

            modelBuilder.Entity<Osoba>().HasData(new Osoba[]
                {
                    new Osoba{ Id = -1, Name = "Pera", Surname="Peric"},
                    new Osoba{ Id = -2, Name = "Neko", Surname="Nekic"},
                    new Osoba{ Id = -3, Name = "Trecko", Surname="Treckovic"}
                });
        }
    }
}
