using MRCryptocompareClient.Node;
using MRCryptocompareClient.Tools;

namespace MRCryptocompareClient.Client
{
    /// <summary>
    /// Cryptocompare api client
    /// </summary>
    public class CryptocompareClient
    {
        /// <summary>
        /// Primary service access token
        /// </summary>
        public string AccessToken { get; protected set; }

        /// <summary>
        /// Your application name
        /// </summary>
        public string ApplicationName { get; protected set; }

        #region Nodes

        public  NodeHistorical Historical { get; protected set; }

        #endregion

        public CryptocompareClient()
        {
            Historical = new NodeHistorical(this);
        }

        /// <summary>
        /// Set service access token
        /// </summary>
        /// <param name="accessToken">Service access token</param>
        /// <returns></returns>
        public CryptocompareClient SetAccessToken(string accessToken)
        {
            AccessToken = accessToken;
            return this;
        }

        /// <summary>
        /// Set application name is extra param for requests
        /// </summary>
        /// <param name="applicationName">Your application name</param>
        /// <returns></returns>
        public CryptocompareClient SetApplicationName(string applicationName)
        {
            ApplicationName = applicationName;
            return this;
        }

        public CryptocompareClient SetCredentions(string accessToken, string applicationName) 
            => SetAccessToken(accessToken).SetApplicationName(applicationName);
    }
}
