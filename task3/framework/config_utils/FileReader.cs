using Newtonsoft.Json;

namespace task3.framework.config_utils
{
    public class FileReader
    {
        public static T ReadJsonDataFile<T>() where T : IConfig
        {
            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, T.GetConfigFilePath());
            var jsonText = File.ReadAllText(configPath);
            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }
}
