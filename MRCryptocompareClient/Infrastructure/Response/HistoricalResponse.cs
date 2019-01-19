using Newtonsoft.Json;

namespace MRCryptocompareClient.Infrastructure.Response
{
    public class HistoricalResponse : ListResponse<HistoricalData> { }

    public class HistoricalData
    {
        public long Time { get; set; }
        public float Close { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public float Open { get; set; }

        [JsonProperty("volumefrom")]
        public float VolumeFrom { get; set; }

        [JsonProperty("volumeto")]
        public float VolumeTo { get; set; }
    }
}
