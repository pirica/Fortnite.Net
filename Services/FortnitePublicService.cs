using System.Threading.Tasks;
using Fortnite.Net.Model.Fortnite;
using RestSharp;

namespace Fortnite.Net.Services
{
    public sealed class FortnitePublicService : EpicServiceBase
    {

        public FortnitePublicService(FortniteApi api) : base(api, "https://fortnite-public-service-prod11.ol.epicgames.com/")
        { }

        public async Task<object> ClientCommandAsync(string command, string profileId, object body) =>
            await SendBaseAsync<object>($"/fortnite/api/game/v2/profile/{_api.LoginModel.AccountId}/client/{command}?profileId={profileId}", Method.POST, true, request =>
            {
                request.AddJsonBody(body);
            });

        public object ClientCommand(string command, string profileId, object body) =>
            ClientCommandAsync(command, profileId, body).GetAwaiter().GetResult();

        public async Task<FortCatalogResponse> GetStoreFrontCatalogAsync() =>
            await SendBaseAsync<FortCatalogResponse>("/fortnite/api/storefront/v2/catalog");

       public FortCatalogResponse GetStoreFrontCatalog() =>
           GetStoreFrontCatalogAsync().GetAwaiter().GetResult();

    }
}