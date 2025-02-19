using MySite.Feature.PageContent.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MySite.Feature.PageContent.Helper
{
    public class JsonSerializeHelper
    {
        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(
                    obj
                    , new JsonSerializerSettings
                    {
                        ContractResolver = new DefaultContractResolver
                        {
                            NamingStrategy = new CamelCaseNamingStrategy()
                        },
                        Formatting = Formatting.Indented
                    });
        }
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}