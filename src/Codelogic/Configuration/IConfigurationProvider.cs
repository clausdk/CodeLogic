namespace CodeLogic.Configurations
{
    public interface IConfigurationProvider
    {
        T GetConfiguration<T>();
        void SaveConfiguration<T>(T configuration);
    }
}
