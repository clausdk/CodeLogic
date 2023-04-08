using System.IO;
using Newtonsoft.Json;

namespace CodeLogic.Configurations
{
    public class JsonFileConfigurationProvider : IConfigurationProvider
    {
        private readonly string _configFolder;

        public JsonFileConfigurationProvider(string configFolder)
        {
            _configFolder = configFolder;
        }

        public T GetConfiguration<T>()
        {
            var configFilePath = GetConfigFilePath(typeof(T).Name);

            if (!File.Exists(configFilePath))
            {
                return default(T);
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
            return Path.Combine(_configFolder, $"{configName}.json");
        }
    }
}
