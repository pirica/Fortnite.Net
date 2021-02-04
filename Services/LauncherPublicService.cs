using System.Threading.Tasks;
using Fortnite.Net.Model.Manifest;
using Fortnite.Net.Utils;
using RestSharp;

namespace Fortnite.Net.Services
{
    public class LauncherPublicService : EpicServiceBase
    {
        
        public LauncherPublicService(FortniteApi api) : base(api, "https://launcher-public-service-prod06.ol.epicgames.com") { }

        public async Task<AppManifest> GetManifestAsync()
        {
            _api.EgLoginModel = await _api.AccountPublicService.GetEgTokenAsync();
            return await SendBaseAsync<AppManifest>("/launcher/api/public/assets/Windows/4fe75bbc5a674f4f9b356b5c90567da5/Fortnite?label=Live", Method.GET, false,
                request =>
                {
                    request.AddHeader("Authorization", $"bearer {_api.EgLoginModel.AccessToken}");
                });
        }

        public AppManifest GetManifest() =>
            GetManifestAsync().GetAwaiter().GetResult();

        public async Task<ChunkManifest> GetChunkManifestAsync(AppManifest manifest)
        {
            var item = manifest.Items["MANIFEST"];
            var request = new RestRequest($"{item.Distribution}{item.Path}?{item.Signature}");
            var response = await FortniteApi.DefaultRestClient.HandleRequest<ChunkManifest>(request);
            return response;
        }

        public ChunkManifest GetChunkManifest(AppManifest manifest) =>
            GetChunkManifestAsync(manifest).GetAwaiter().GetResult();

        public async Task<ChunkManifest> GetChunkManifestAsync()
        {
            var manifest = await GetManifestAsync();
            return await GetChunkManifestAsync(manifest);
        }

        public ChunkManifest GetChunkManifest() =>
            GetChunkManifestAsync().GetAwaiter().GetResult();

    }
}