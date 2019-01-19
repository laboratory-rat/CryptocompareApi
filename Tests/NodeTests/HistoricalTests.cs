using MRCryptocompareClient.Infrastructure.Model.Historical;
using System.Threading.Tasks;
using Xunit;

namespace Tests.NodeTests
{
    public class HistoricalTests : BaseTestController
    {
        [Fact(DisplayName = "Historical Day")]
        public async Task TestHistoricalDaily()
        {
            var client = GetClient();
            var response = await client.Historical.Daily(GetHistoricalRequest());

            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
        }

        [Fact(DisplayName = "Historical Hour")]
        public async Task TestHistoricalHourly()
        {
            var client = GetClient();
            var response = await client.Historical.Hourly(GetHistoricalRequest());

            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
        }

        [Fact(DisplayName = "Historical Minute")]
        public async Task TestHistoricalMinutle()
        {
            var client = GetClient();
            var response = await client.Historical.Minutly(GetHistoricalRequest());

            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
        }

        protected HistoricalAny GetHistoricalRequest()
        {
            return new HistoricalAny
            {
                Fsym = "BTC",
                Tsym = "USD",
                Limit = 10
            };
        }
    }
}
