using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Xero.Api.Core.Model
{
    public static class EnumExtensions
    {
        public static string GetEnumMemberValue(this Enum value)
        {
            var type = value.GetType();
            var memInfo = type.GetTypeInfo().GetMember(value.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false).ToList();
            return (attributes.Count > 0) ? ((EnumMemberAttribute)attributes[0]).Value : value.ToString("");
        }

    }
}
