using System.IO;

namespace CodeLogic
{
    public static class Defaults
    {
        public static string ExtensionsFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Extensions");
        public static string ConfigsFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage", "Configs");
        public static string LogsFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage", "Logs");

        public static void EnsureFoldersExist()
        {
            Directory.CreateDirectory(ExtensionsFolder);
            Directory.CreateDirectory(ConfigsFolder);
            Directory.CreateDirectory(LogsFolder);
        }
    }
}
