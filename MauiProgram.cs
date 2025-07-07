using Microsoft.Extensions.Logging;

namespace GonzalezFabioExamen3P
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "contactos.db3");
            builder.Services.AddSingleton(new DatabaseService(dbPath));
            builder.Services.AddSingleton<LogService>();

            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit();

            return builder.Build();
        }
    }
}
