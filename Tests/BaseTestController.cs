using MRCryptocompareClient.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public abstract class BaseTestController
    {
        const string ACCESS_TOKEN = "66060780779df9e3b6f4c8716981c526fe12d94b576b7d51dd38a1d8e0cfc82b";
        const string APPLICATION_NAME = "C#_MR_SDK";

        public CryptocompareClient GetClient() => new CryptocompareClient().SetCredentions(ACCESS_TOKEN, APPLICATION_NAME);
    }
}
