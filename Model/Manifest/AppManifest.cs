using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fortnite.Net.Model.Manifest
{
    public class AppManifest
    {
        
        public string AppName;
        public string LabelName;
        public string BuildVersion;
        public string CatalogItemId;
        public string Expires;
        [JsonProperty("asset_id")] 
        public string AssetId;
        public Dictionary<string, AppManifestItem> Items;
        
    }
}