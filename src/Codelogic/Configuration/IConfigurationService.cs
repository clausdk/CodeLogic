namespace CodeLogic.Configurations
{
    public interface IConfigurationService
    {
        T GetConfiguration<T>(string extensionName);
        void SaveConfiguration<T>(string extensionName, T configuration);
    }
}
