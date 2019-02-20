using System.IO;

namespace Xero.Api.Infrastructure.Interfaces
{
    public interface IJsonObjectMapper
    {
        T From<T>(Stream result);
        T From<T>(string result);
        string To<T>(T request);
        void To<T>(T request, Stream writeStream);
    }
}