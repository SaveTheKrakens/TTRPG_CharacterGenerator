using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChimerasCauldron.Utils
{
    internal static class JSONKeyExtracter
    {
        public static HashSet<string> GetAllKeys(string filePath)
        {
            using var stream = File.OpenRead(filePath);
            using var document = JsonDocument.Parse(stream);
            var keys = new HashSet<string>();
            ExtractKeys(document.RootElement, keys);
            return keys;
        }

        private static void ExtractKeys(JsonElement element, HashSet<string> keys)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    foreach (var property in element.EnumerateObject())
                    {
                        keys.Add(property.Name);
                        ExtractKeys(property.Value, keys);
                    }
                    break;
                case JsonValueKind.Array:
                    foreach (var item in element.EnumerateArray())
                    {
                        ExtractKeys(item, keys);
                    }
                    break;
                    // Other types (string, number, etc.) do not have keys
            }
        }
    }
}
