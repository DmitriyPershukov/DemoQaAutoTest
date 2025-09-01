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
        public static T GetTestDataModel<T>() where T : IConfig
        {
            return FileReader.ReadJsonDataFile<T>();
        }
    }
}
