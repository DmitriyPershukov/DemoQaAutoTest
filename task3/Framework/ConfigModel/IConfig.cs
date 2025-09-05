namespace task3.Framework.ConfigModel
{
    public interface IConfig
    {
        virtual static string GetConfigFilePath() { throw new NotImplementedException(); }
    }
}
