namespace MauiApp6;

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
                fonts.AddFont("Simple Print.ttf", "Simple");
                fonts.AddFont("Rantera.otf", "Rant");
                fonts.AddFont("simpletix.otf", "Simp");
            });

		return builder.Build();
	}
}
