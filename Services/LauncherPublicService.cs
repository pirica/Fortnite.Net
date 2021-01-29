using System.Threading.Tasks;
using Fortnite.Net.Model.Manifest;
using RestSharp;

namespace Fortnite.Net.Services
{
    public class LauncherPublicService : EpicServiceBase
    {
        
        public LauncherPublicService(FortniteApi api) : base(api, "https://launcher-public-service-prod06.ol.epicgames.com") { }

        public async Task<AppManifest> GetManifestAsync()
        {
            _api.EgLoginModel = await _api.AccountPublicService.GetEgToken();
            return await SendBaseAsync<AppManifest>("/launcher/api/public/assets/Windows/4fe75bbc5a674f4f9b356b5c90567da5/Fortnite?label=Live", Method.GET, false,
                request =>
                {
                    request.AddHeader("Authorization", $"bearer {_api.EgLoginModel.AccessToken}");
                });
        }

        public AppManifest GetManifest() =>
            GetManifestAsync().GetAwaiter().GetResult();

    }
}