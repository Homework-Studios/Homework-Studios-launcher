namespace Homework_Studios_Launcher;

public class AppdataDataSaver
{
    public static DirectoryInfo appdatafolder =
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                  "\\HW-SLauncher");

    public static bool SafeCreateFile(string filename)
    {
        if (File.Exists(appdatafolder.FullName + "\\" + filename)) return false;

        File.Create(appdatafolder.FullName + "\\" + filename);
        return true;
    }


    public static void SaveData(string filename, string data)
    {
        File.WriteAllText(appdatafolder.FullName + "\\" + filename, data);
    }

    public static void AddData(string filename, string data)
    {
        File.AppendAllText(appdatafolder.FullName + "\\" + filename, data);
    }

    public static string ReadData(string filename)
    {
        return File.ReadAllText(appdatafolder.FullName + "\\" + filename);
    }
}