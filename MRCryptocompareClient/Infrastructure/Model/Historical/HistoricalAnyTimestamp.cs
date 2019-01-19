using MRCryptocompareClient.Infrastructure.Enum;

namespace MRCryptocompareClient.Infrastructure.Model.Historical
{
    public class HistoricalAnyTimestamp : HistoricalBase
    {
        /// <summary>
        /// The unix timestamp of interest
        /// </summary>
        public double Ts { get; set; }

        /// <summary>
        /// Type of average to calculate  
        /// [ Min length - 2] [ Max length - 30] [ Default - Close]
        /// </summary>
        public CalculationType CalculationType { get; set; }
    }
}
