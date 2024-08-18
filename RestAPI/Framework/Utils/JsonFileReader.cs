using Newtonsoft.Json;

namespace RestAPI.Framework.Utils
{
    public static class JsonFileReader
    {
        public static T ReadFromFile<T>(string filePath) where T : class
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
