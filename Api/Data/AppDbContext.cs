using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api;
public class AppDbContext : IdentityDbContext // для взаимодействия с базой
{
    // DbContextOptions объект содержит настройки для контекста базы данных, такие как строка подключения, провайдер базы данных
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<AppUser> AppUsers { get; set; } // описание новой таблицы
    public DbSet<Product> Products { get; set; } // таблица Products
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<OrderHeader> OrderHeaders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Product>().HasData(FakeProductGenerator.GenerateProductList());
    }

}
