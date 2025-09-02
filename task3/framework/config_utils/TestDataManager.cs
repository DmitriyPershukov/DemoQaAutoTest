using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.test.config;

namespace task3.framework.config_utils
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
