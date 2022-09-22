namespace Homework_Studios_Launcher;

internal static class Program
{
    public static bool server;
    public static List<Game> games = new();

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HW-SLauncher";
        if (!Directory.Exists(appdata))
            Directory.CreateDirectory(appdata);

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new StartForm());
        if (server)
            Application.Run(new ServerForm());
        else Application.Run(new Main());
    }
}