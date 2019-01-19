using MRCryptocompareClient.Client;
using MRCryptocompareClient.Infrastructure.Props;
using MRCryptocompareClient.Tools;

namespace MRCryptocompareClient.Infrastructure.Interface
{
    public abstract class INode
    {
        protected readonly CryptocompareClient _client;
        protected CryptoCompoirerRequestSender RequestSender => new CryptoCompoirerRequestSender();

        public INode(CryptocompareClient client)
        {
            _client = client;
        }

        protected UrlPropertyCollection ParseFull<T>(T model)
            where T : IRequestModel, new()
        {
            if (!string.IsNullOrWhiteSpace(_client.ApplicationName))
            {
                model.SetApplicationName(_client.ApplicationName);
            }

            return new UrlPropertyCollection(model, _client.AccessToken);
        }

    }
}
