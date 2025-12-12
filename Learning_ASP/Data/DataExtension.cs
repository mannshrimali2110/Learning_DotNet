
using Microsoft.EntityFrameworkCore;

namespace Learning_ASP.Data;

public static class DataExtension
{

    public static void MigrateDB(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;

        var context = services.GetRequiredService<GameStoreContext>();
        context.Database.Migrate();
    }

}
