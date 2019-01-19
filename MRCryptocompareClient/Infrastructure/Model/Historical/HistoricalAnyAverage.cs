using MRCryptocompareClient.Infrastructure.Enum;

namespace MRCryptocompareClient.Infrastructure.Model.Historical
{
    public class HistoricalAnyAverage : HistoricalBase
    {
        /// <summary>
        /// Type of average to calculate.
        /// [ Default - HourVWAP]
        /// </summary>
        public AvgType AvgType { get; set; } = AvgType.HourVWAP;

        /// <summary>
        /// By deafult it does UTC, if you want a different time zone just pass the hour difference. 
        /// For PST you would pass -8 for example. 
        /// [ Min - -12] [ Max - 14] [ Default - 0]
        /// </summary>
        public int UTCHourDiff { get; set; } = 0;

        /// <summary>
        /// Returns historical data before that timestamp.
        /// </summary>
        public double ToTs { get; set; }
    }

}
