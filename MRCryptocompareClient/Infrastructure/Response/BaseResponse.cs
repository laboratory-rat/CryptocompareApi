using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace MRCryptocompareClient.Infrastructure.Response
{
    public class BaseResponse
    {
        public string Response { get; set; }
        public int Type { get; set; }
        public bool Aggregated { get; set; }
        public string Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => Exception == null && HttpResponse != null && HttpResponse.IsSuccessStatusCode && Response.Equals("Success");

        public long TimeTo { get; set; }
        public long TimeFrom { get; set; }

        public ResponseConversionType ConversionType { get; set; }

        public bool HasWarning { get; set; }

        [JsonIgnore]
        public Exception Exception { get; set; }

        [JsonIgnore]
        public HttpResponseMessage HttpResponse { get; set; }


        public BaseResponse SetException(Exception ex)
        {
            Exception = ex;
            return this;
        }

        public BaseResponse SetHttpResponse(HttpResponseMessage message)
        {
            HttpResponse = message;
            return this;
        }
    }

    public class ResponseConversionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("conversionSymbol")]
        public string ConversionSymbol { get; set; }
    }
}
