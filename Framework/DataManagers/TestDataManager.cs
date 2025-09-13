using task3.Framework.ConfigModel;
using task3.Framework.Utils;

namespace task3.Framework.DataManagers
{
    public class TestDataManager
    {
        private static Dictionary<string, IConfig> modelNameModelMap = new Dictionary<string, IConfig>();
        public static T GetTestDataModel<T>() where T : IConfig
        {
            var modelName = typeof(T).Name;
            if (!modelNameModelMap.ContainsKey(modelName))
            {
                modelNameModelMap.Add(modelName, FileReader.ReadJsonDataFile<T>());
            }
            return (T)modelNameModelMap[modelName];
        }
    }
}
