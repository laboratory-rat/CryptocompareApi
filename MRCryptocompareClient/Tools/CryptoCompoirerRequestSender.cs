using MRCryptocompareClient.Infrastructure.Props;
using MRCryptocompareClient.Infrastructure.Response;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MRCryptocompareClient.Tools
{
    public class CryptoCompoirerRequestSender
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<T> GetAsync<T>(string url, UrlPropertyCollection @params)
            where T : BaseResponse, new()
            => await GetAsync<T>(url + (@params == null ? "" : @params.ToString()));

        public async Task<T> GetAsync<T>(string fullUrl)
            where T : BaseResponse, new()
        {
            T response = default(T);

            try
            {
                var httpResponse = await client.GetAsync(fullUrl);

                if (!httpResponse.IsSuccessStatusCode)
                {
                    response = (T)new BaseResponse().SetHttpResponse(httpResponse);
                }
                else
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<T>(await httpResponse.Content.ReadAsStringAsync());
                    response.SetHttpResponse(httpResponse);
                }
            }
            catch (Exception ex)
            {
                response = (T)new BaseResponse()
                    .SetException(ex);
            }

            return response;
        }

    }
}
