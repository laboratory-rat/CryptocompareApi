using MRCryptocompareClient.Tools.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MRCryptocompareClient.Infrastructure.Props
{
    /// <summary>
    /// Basic collection of url properties.
    /// </summary>
    public class UrlPropertyCollection : List<UrlProperty>
    {
        public readonly Type[] SIMPLE_PARSEBLE_TYPES = new Type[]
        {
            typeof(int),
            typeof(long),
            typeof(double),
            typeof(string),
            typeof(int?),
            typeof(long?),
            typeof(double?),
        };

        public readonly Type[] BOOLEAN_PARSEBLE_TYPES = new Type[]
        {
            typeof(bool),
            typeof(bool?)
        };

        public readonly Type[] STRING_COLLECTION_TYPES = new Type[]
        {
            typeof(string[]),
            typeof(List<string>),
            typeof(IEnumerable<string>),
            typeof(ICollection<string>)
        };

        public UrlPropertyCollection() { }

        public UrlPropertyCollection(object source) : this()
        {
            ParseObject(source);
        }

        public UrlPropertyCollection(object source, string access_token) : this(source)
        {
            AddAccessToken(access_token);
        }

        /// <summary>
        /// Add access token to collection.
        /// </summary>
        /// <param name="accessToken">Service access token</param>
        /// <returns></returns>
        public UrlPropertyCollection AddAccessToken(string accessToken)
        {
            Add(new UrlProperty("api_key", accessToken));
            return this;
        }

        /// <summary>
        /// Transform object to Url property collection.
        /// </summary>
        /// <param name="target">Object to transform</param>
        /// <returns></returns>
        public UrlPropertyCollection ParseObject(object target)
        {
            foreach (var propertyInfo in target.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var type = propertyInfo.PropertyType;
                if (SIMPLE_PARSEBLE_TYPES.Contains(type) || type.IsEnum)
                {
                    var value = propertyInfo.GetValue(target)?.ToString();
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        Add(new UrlProperty(propertyInfo.Name.ToFirstLowerCase(), value));
                    }
                }
                else if (BOOLEAN_PARSEBLE_TYPES.Contains(type))
                {
                    var value = propertyInfo.GetValue(target)?.ToString();
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        Add(new UrlProperty(propertyInfo.Name.ToFirstLowerCase(), value == "True" ? 1 : 0));
                    }
                }
                else if (STRING_COLLECTION_TYPES.Contains(type))
                {
                    var value = (IEnumerable<string>)propertyInfo.GetValue(target);
                    if(value != null)
                    {
                        Add(new UrlProperty(propertyInfo.Name.ToFirstLowerCase(), string.Join(",", value.Select(x => x.ToString()))));
                    }
                }
            }

            return this;
        }

        /// <summary>
        /// Transform collection to ?XX=xx&ZZ=zz string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Count == 0)
                return string.Empty;

            return "?" + string.Join("&", this.Select(x => x.ToString()));
        }
    }
}
