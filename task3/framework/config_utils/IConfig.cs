namespace task3.framework.config_utils
{
    public interface IConfig
    {
        virtual static string GetConfigFilePath() { throw new NotImplementedException(); }
    }
}
