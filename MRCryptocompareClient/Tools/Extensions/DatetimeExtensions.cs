using System;
using System.Collections.Generic;
using System.Text;

namespace MRCryptocompareClient.Tools.Extensions
{
    public static class DatetimeExtensions
    {
        public static DateTime UNIX_START_DATETIME => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime UnixTimeStampToDateTime(this DateTime target, double source) => UNIX_START_DATETIME.AddSeconds(source).ToLocalTime();

        public static double DateTimeToUnixTimestamp(this DateTime source) => (TimeZoneInfo.ConvertTimeToUtc(source) - UNIX_START_DATETIME).TotalSeconds;
    }
}
