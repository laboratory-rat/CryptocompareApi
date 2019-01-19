using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MRCryptocompareClient.Infrastructure.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    /// <summary>
    /// Type of average to calculate
    /// </summary>
    public enum CalculationType
    {
        /// <summary>
        /// a Close of the day close price.
        /// </summary>
        Close,

        /// <summary>
        ///  the average between the 24 H high and low.
        /// </summary>
        MidHighLow,

        /// <summary>
        ///  the total volume to / the total volume from.
        /// </summary>
        VolFVolT
    }

    [JsonConverter(typeof(StringEnumConverter))]
    /// <summary>
    /// Type of average to calculate
    /// </summary>
    public enum AvgType
    {
        /// <summary>
        /// a HourVWAP of hourly price
        /// </summary>
        HourVWAP,

        /// <summary>
        ///  the average between the 24 H high and low
        /// </summary>
        MidHighLow,

        /// <summary>
        ///  the total volume to / the total volume from
        /// </summary>
        VolFVolT
    }
}
