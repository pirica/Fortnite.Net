using System.Collections.Generic;

namespace Fortnite.Net.Model.Manifest
{
    public class ChunkManifest
    {

        public string AppNameString;
        public string BuildVersionString;
        public List<ChunkManifestFile> FileManifestList;
        public Dictionary<string, string> ChunkHashList;
        public Dictionary<string, string> DataGroupList;
        
    }
}