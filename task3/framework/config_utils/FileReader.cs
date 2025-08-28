using Newtonsoft.Json;

namespace task3.framework.config_utils
{
    internal class FileReader
    {
        internal static T ReadJsonDataFile<T>() where T : IConfig
        {
            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "framework\\config\\config_files\\", T.GetConfigFileName());
            var jsonText = File.ReadAllText(configPath);
            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }
}
