using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Api;

public static class PosgreSqlServiceExtension
/* класс для вынесения подключения к бд */
{
    public static void AddPosgreSqlDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        // указываем, что мы используем тот dbcontext
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection")); // использованная строка подключения  
        });
    }

    public static void AddPostgreSqlIdentityContext(
        this IServiceCollection services
    )
    /* работа с пользователями */
    {
        services.AddIdentity<AppUser, IdentityRole>() // AppUser - новая таблица в AppDbContext
            .AddEntityFrameworkStores<AppDbContext>();
    }
}
