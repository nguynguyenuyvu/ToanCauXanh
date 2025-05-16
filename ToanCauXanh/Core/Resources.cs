using ToanCauXanh.Models;
using Newtonsoft.Json;

namespace ToanCauXanh.Core
{
    public static class Resources
    {
        private static Dictionary<string, string> AllResourcesJSON = new Dictionary<string, string>();
        private static List<string> Languages = new List<string> { "vi", "en" };

        public static void LoadResourceJSON(IWebHostEnvironment env)
        {
            foreach (string language in Languages)
            {
                string filePath = Path.Combine(env.ContentRootPath, "Language", $"{language}.json");

                if (!File.Exists(filePath))
                    continue;

                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    List<LanguageModel> items = JsonConvert.DeserializeObject<List<LanguageModel>>(json);
                    foreach (LanguageModel item in items)
                    {
                        AllResourcesJSON[item.ResourceKey + "-" + language] = item.ResourceValue;
                    }
                }
            }
        }

        public static string GetLanguageJSON(string Key)
        {
            if (AllResourcesJSON.ContainsKey(Key))
            {
                return AllResourcesJSON[Key];
            }
            return "Null";
        }
    }
}
