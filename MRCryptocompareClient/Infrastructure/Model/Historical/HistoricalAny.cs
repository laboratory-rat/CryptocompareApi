namespace MRCryptocompareClient.Infrastructure.Model.Historical
{
    public class HistoricalAny : HistoricalBase
    {
        /// <summary>
        /// Time period to aggregate the data over (for daily it's days, for hourly it's hours and for minute histo it's minutes)
        /// [ Min - 1] [ Max - 30] [ Default - true]
        /// </summary>
        public bool Aggregate { get; set; } = true;

        /// <summary>
        /// True by default, only used when the aggregate param is also in use. 
        /// If false it will aggregate based on the current time.If the param is false and the time you make the call is 1pm - 2pm, with aggregate 2, it will create the time slots: ...
        /// 9am, 11am, 1pm.If the param is false and the time you make the call is 2pm - 3pm, with aggregate 2, it will create the time slots: ... 10am, 12am, 2pm.
        /// If the param is true (default) and the time you make the call is 1pm - 2pm, with aggregate 2, it will create the time slots: ... 8am, 10am, 12pm.
        /// If the param is true (default) and the time you make the call is 2pm - 3pm, with aggregate 2, it will create the time slots: ... 10am, 12am, 2pm. 
        /// [ Default - true]
        /// </summary>
        public bool AggregatePredictableTimePeriods { get; set; } = true;

        /// <summary>
        /// The number of data points to return 
        /// [ Min - 1] [ Max - 2000] [ Default - 30]
        /// </summary>
        public int Limit { get; set; } = 30;

        /// <summary>
        /// Returns all data (only available on histo day) 
        /// [ Default - false]
        /// </summary>
        public bool AllData { get; set; } = false;

        /// <summary>
        /// Returns historical data before that timestamp. 
        /// If you want to get all the available historical data, you can use limit=2000 and keep going back in time using the toTs param.
        /// You can then keep requesting batches using: &limit=2000&toTs={the earliest timestamp received}
        /// </summary>
        public double? ToTs { get; set; }
    }

}
