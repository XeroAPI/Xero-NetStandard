using System;
using System.Collections.Specialized;

namespace Xero.Api.Common
{
    internal static class Extensions
    {
        public static void AddIfNotNull(this NameValueCollection collection, string name, Guid? value)
        {
            if (value.HasValue)
            {
                collection.Add(name, value.Value.ToString("D"));
            }
        }

        public static void AddIfNotNull(this NameValueCollection collection, string name, int? value)
        {
            if (value.HasValue)
            {
                collection.Add(name, value.Value.ToString("D"));
            }
        }

        public static void AddIfNotNull(this NameValueCollection collection, string name, bool? value)
        {
            if (value.HasValue)
            {
                collection.Add(name, value.Value.ToString().ToLower());
            }
        }

        public static void AddIfNotNull(this NameValueCollection collection, string name, DateTime? value)
        {
            if (value.HasValue)
            {
                collection.Add(name, value.Value.ToString("yyyy-MM-dd"));
            }
        }

        public static void AddIfNotNull(this NameValueCollection collection, string name, string value)
        {
            if (value != null)
            {
                collection.Add(name, value.ToLower());
            }
        }
    }
}
