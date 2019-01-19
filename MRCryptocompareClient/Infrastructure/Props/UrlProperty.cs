using System;
using System.Collections.Generic;
using System.Text;

namespace MRCryptocompareClient.Infrastructure.Props
{
    /// <summary>
    /// Url property
    /// </summary>
    public class UrlProperty
    {
        public string Key { get; set; }
        public object Value { get; set; }

        public UrlProperty()
        {

        }

        public UrlProperty(string key, object value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString() => $"{Key}={Value.ToString()}";
    }
}
