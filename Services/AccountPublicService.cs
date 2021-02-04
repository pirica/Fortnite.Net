using System.Threading.Tasks;
using Fortnite.Net.Model.Account;
using RestSharp;

namespace Fortnite.Net.Services
{
    public sealed class AccountPublicService : EpicServiceBase
    {

        public AccountPublicService(FortniteApi api) : base(api, "https://account-public-service-prod.ol.epicgames.com/")
        { }

        public async Task<string[]> GetSsoDomainsAsync() =>
            await SendBaseAsync<string[]>("/account/api/epicdomains/ssodomains");

        public string[] GetSsoDomains() =>
            GetSsoDomainsAsync().GetAwaiter().GetResult();

        public async Task<GameProfile> GetUserFromEmailAsync(string email) =>
            await SendBaseAsync<GameProfile>($"/account/api/public/account/email/{email}");

        public GameProfile GetUserFromEmail(string email) =>
            GetUserFromEmailAsync(email).GetAwaiter().GetResult();

        public async Task<VerifyResponse> VerifyTokenAsync(bool includePerms = false) =>
            await SendBaseAsync<VerifyResponse>($"/account/api/oauth/verify?includePerms={includePerms}");

        public async Task<VerifyResponse> VerifyTokenAsync(LoginModel loginModel, bool includePerms = false) =>
            await VerifyTokenAsync(loginModel.AccountId, includePerms);

        public async Task<VerifyResponse> VerifyTokenAsync(string token, bool includePerms = false) =>
            await SendBaseAsync<VerifyResponse>($"/account/api/oauth/verify?includePerms={includePerms}", Method.GET, false, req =>
            {
                req.AddHeader("Authorization", $"bearer {token}");
            });

        public VerifyResponse VerifyToken(bool includePerms = false) =>
            VerifyTokenAsync(includePerms).GetAwaiter().GetResult();

        public VerifyResponse VerifyToken(LoginModel loginModel, bool includePerms = false) =>
            VerifyTokenAsync(loginModel.AccountId, includePerms).GetAwaiter().GetResult();

        public VerifyResponse VerifyToken(string token, bool includePerms = false) =>
            VerifyTokenAsync(token, includePerms).GetAwaiter().GetResult();

        public async Task<LoginModel> GetEgTokenAsync() => 
            await SendBaseAsync<LoginModel>("/account/api/oauth/token", Method.POST, false, request =>
            {
                request.AddParameter("grant_type", "client_credentials");
                request.AddParameter("token_type", "eg1");
                request.AddHeader("Authorization", $"basic {ClientToken.EgsClient}");
            });

        public LoginModel GetEgToken() =>
            GetEgTokenAsync().GetAwaiter().GetResult();

        public async Task KillAuthSessionsAsync(string killType)
        {
            await SendBaseAsync<object>($"/account/api/oauth/sessions/kill?killType={killType}", Method.DELETE);
        }

        public void KillAuthSessions(string killType) =>
            KillAuthSessionsAsync(killType).GetAwaiter().GetResult();

        public async Task KillAuthSessionAsync(string accessToken)
        {
            await SendBaseAsync<object>($"/account/api/oauth/sessions/kill/{accessToken}", Method.DELETE);
        }

        public void KillAuthSession(string accessToken) =>
            KillAuthSessionAsync(accessToken).GetAwaiter().GetResult();

        public async Task<object> QueryUserInfoAsync(string id) =>
            await SendBaseAsync<object>($"/account/api/public/account/{id}");
        
        

        // TODO queryExternalIdMappingsByDisplayName
        // TODO queryExternalIdMappingsById
        // TODO queryUserIdFromEmail
        // TODO removeExternalAccount
        // TODO queryExternalAccountsByType
        // TODO queryExternalAccounts
        // TODO deleteDeviceAuth
        // TODO createDeviceAuth
        // TODO queryDeviceAuths 2x
        // TODO queryUserMetaData

    }
}