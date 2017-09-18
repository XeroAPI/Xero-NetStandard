using System.Net;

namespace Xero.Api.Infrastructure.ThirdParty.Dust.Core.SignatureBaseStringParts.Parameters
{
    internal class ParameterEncoding
    {
        internal string Escape(string what)
        {
            return WebUtility.UrlEncode(what ?? string.Empty);
        }
    }
}