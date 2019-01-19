namespace MRCryptocompareClient.Tools
{
    /// <summary>
    /// Base SDK navigator class
    /// </summary>
    public static class Navigator
    {
        /// <summary>
        /// Base service url
        /// </summary>
        const string BASE_URL = "https://min-api.cryptocompare.com/data";

        /// <summary>
        /// Historical url
        /// </summary>
        public static string HistoricalDaily => $"{BASE_URL}/histoday";

        public static string HistoricalHourly => $"{BASE_URL}/histohour";

        public static string HistoricalMinutly => $"{BASE_URL}/histominute";
    }
}
