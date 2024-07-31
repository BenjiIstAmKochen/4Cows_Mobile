using Microsoft.Extensions.Logging;
using BB_Cow.Services;
using MudBlazor.Services;

namespace _4Cows_Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();
        builder.Services.AddSingleton<ClawTreatmentService>();
        builder.Services.AddSingleton<CowTreatmentService>();
        builder.Services.AddSingleton<PCowTreatmentService>();
        builder.Services.AddSingleton<PClawTreatmentService>();


#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}