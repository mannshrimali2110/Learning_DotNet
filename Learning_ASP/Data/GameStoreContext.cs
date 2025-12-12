
using Learning_ASP.Entities;
using Microsoft.EntityFrameworkCore;

namespace Learning_ASP.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options)
: DbContext(options)
{

    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>()
            .HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Adventure" },
                new Genre { Id = 3, Name = "RPG" },
                new Genre { Id = 4, Name = "Strategy" }
            );

        base.OnModelCreating(modelBuilder);
    }

}
