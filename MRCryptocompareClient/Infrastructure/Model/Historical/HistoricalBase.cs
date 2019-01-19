using MRCryptocompareClient.Infrastructure.Interface;
using System.Collections.Generic;

namespace MRCryptocompareClient.Infrastructure.Model.Historical
{
    public abstract class HistoricalBase : IRequestModel
    {
        /// <summary>
        /// If set to false, it will try to get only direct trading values 
        /// [ Default - true]
        /// </summary>
        public bool TryConversion { get; set; } = true;

        /// <summary>
        /// The cryptocurrency symbol of interest 
        /// [ Min length - 1] [ Max length - 10]
        /// </summary>
        public string Fsym { get; set; }

        /// <summary>
        /// The currency symbol to convert into 
        /// [ Min length - 1] [ Max length - 10]
        /// </summary>
        public string Tsym { get; set; }

        /// <summary>
        /// The exchange to obtain data from (our aggregated average - CCCAGG - by default) 
        /// [ Min length - 2] [ Max length - 30] [ Default - CCCAGG]
        /// </summary>
        public string E { get; set; } = "CCCAGG";

        /// <summary>
        /// If set to true, the server will sign the requests (by default we don't sign them),
        /// this is useful for usage in smart contracts 
        /// [ Default - false]
        /// </summary>
        public bool Sign { get; set; } = false;
    }
}
