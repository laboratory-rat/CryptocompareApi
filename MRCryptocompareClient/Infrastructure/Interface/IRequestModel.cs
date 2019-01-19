using System;
using System.Collections.Generic;
using System.Text;

namespace MRCryptocompareClient.Infrastructure.Interface
{
    public abstract class IRequestModel
    {
        /// <summary>
        /// The name of your application (we recommend you send it) 
        /// Set this param by client.SetApplicationName()
        /// <see cref="Client.CryptocompareClient"/>
        /// </summary>
        public string ExtraParams { get; set; }

        /// <summary>
        /// This method is used by nodes
        /// </summary>
        /// <param name="applicationName"></param>
        /// <returns></returns>
        public IRequestModel SetApplicationName(string applicationName)
        {
            if (!string.IsNullOrWhiteSpace(applicationName))
            {
                ExtraParams = applicationName.Length > 2000 ? applicationName.Substring(0, 1999) : applicationName;
            }

            return this;
        }
    }
}
