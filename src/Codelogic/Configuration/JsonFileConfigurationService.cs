using System.IO;
using Newtonsoft.Json;

namespace CodeLogic.Configurations
{
    public class JsonFileConfigurationService
    {
        private readonly IConfigurationProvider _configProvider;

        public JsonFileConfigurationService(IConfigurationProvider configProvider)
        {
            _configProvider = configProvider;
        }

        public T GetConfiguration<T>() where T : new()
        {
            var configFilePath = GetConfigFilePath(typeof(T).Name);

            if (!File.Exists(configFilePath))
            {
                return new T();
            }

            var configJson = File.ReadAllText(configFilePath);
            var config = JsonConvert.DeserializeObject<T>(configJson);

            return config;
        }

        public void SaveConfiguration<T>(T configuration)
        {
            var configFilePath = GetConfigFilePath(typeof(T).Name);

            var configJson = JsonConvert.SerializeObject(configuration, Formatting.Indented);
            File.WriteAllText(configFilePath, configJson);
        }

        private string GetConfigFilePath(string configName)
        {
            return Path.Combine(_configProvider.ConfigFolder, $"{configName}.json");
        }
    }
}
