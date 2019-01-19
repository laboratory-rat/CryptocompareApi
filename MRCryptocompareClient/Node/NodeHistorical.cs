using MRCryptocompareClient.Client;
using MRCryptocompareClient.Infrastructure.Interface;
using MRCryptocompareClient.Infrastructure.Model.Historical;
using MRCryptocompareClient.Infrastructure.Response;
using MRCryptocompareClient.Tools;
using System.Threading.Tasks;

namespace MRCryptocompareClient.Node
{
    /// <summary>
    /// Get open, high, low, close, volumefrom and volumeto from the daily historical data.The values are based on 00:00 GMT time. 
    /// It uses BTC conversion if data is not available because the coin is not trading in the specified currency. 
    /// If you want to get all the available historical data, you can use limit=2000 and keep going back in time using the toTs param. 
    /// You can then keep requesting batches using: &limit=2000&toTs={the earliest timestamp received}.
    /// https://min-api.cryptocompare.com/documentation?key=Historical&cat=dataHistoday
    /// </summary>
    public class NodeHistorical : INode
    {
        public NodeHistorical(CryptocompareClient client) : base(client) { }

        public async Task<HistoricalResponse> Daily(HistoricalAny model)
        {
            var @params = ParseFull(model);
            var url = Navigator.HistoricalDaily;

            return await RequestSender.GetAsync<HistoricalResponse>(url, @params);
        }

        public async Task<HistoricalResponse> Hourly(HistoricalAny model)
        {
            return await RequestSender.GetAsync<HistoricalResponse>(Navigator.HistoricalHourly, ParseFull(model));
        }

        public async Task<HistoricalResponse> Minutly(HistoricalAny model)
        {
            return await RequestSender.GetAsync<HistoricalResponse>(Navigator.HistoricalMinutly, ParseFull(model));
        }
    }
}
