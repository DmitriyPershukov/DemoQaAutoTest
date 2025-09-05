using Newtonsoft.Json;
using task3.framework.testing_utils;

namespace task3.framework.config_utils
{
    public class FileReader
    {
        public static T ReadJsonDataFile<T>() where T : IConfig
        {
            LoggingManager.GetLogger().Info($"Reading json file for class {typeof(T).Name}");
            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, T.GetConfigFilePath());
            var jsonText = File.ReadAllText(configPath);
            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }
}
