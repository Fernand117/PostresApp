using Microsoft.Extensions.Logging;
using Postres.Infraestructura.HttpService;

namespace Postres.Aplicacion
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            #region INYECCIÓN DE DEPENDENCIAS
            builder.Services.AddScoped<IHttpConfig, HttpConfig>();
            #endregion

            return builder.Build();
        }
    }
}
