using System;
using System.Threading.Tasks;
using Fortnite.Net.Utils;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace Fortnite.Net.Services
{
    public abstract class EpicServiceBase
    {

        internal readonly FortniteApi _api;
        internal readonly RestClient _restClient;

        internal EpicServiceBase(FortniteApi api, string baseUrl)
        {
            _api = api;
            _restClient = new RestClient(baseUrl);
            _restClient.UseSerializer<JsonNetSerializer>();
        }
        
        internal async Task<T> SendBaseAsync<T>(
            string resource,
            Method method = Method.GET,
            bool authorization = true, 
            Action<RestRequest> requestAction = null) 
        where T : class
        {
            var item = _api._cache.Get<T>(resource);
            if (item != null)
            {
                return item;
            }
            var request = new RestRequest(resource, method);
            requestAction?.Invoke(request);
            if (authorization)
            {
                request.AddHeader("Authorization", $"bearer {_api.LoginModel.AccessToken}");
            }
            var response = await _restClient.HandleRequest<T>(request);
            _api._cache.Set(resource, response);
            return response;
        }

    }
}