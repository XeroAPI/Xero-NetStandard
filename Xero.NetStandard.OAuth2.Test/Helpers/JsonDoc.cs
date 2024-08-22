using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xero.NetStandard.OAuth2.Client;
using Xunit;
using Xunit.Sdk;

namespace Xero.NetStandard.OAuth2.Test
{
    internal static class JsonDoc
    {
        public interface IJsonValue
        {
            string PropertyName { get; set; }
            string GetJsonRepresentation();
        }

        public class String : IJsonValue
        {
            private readonly string _input;
            public String(string propertyName, string input)
            {
                _input = input;
                PropertyName = propertyName;
            }
            public string PropertyName { get; set; }
            public string GetJsonRepresentation()
            {
                return $"\"{_input}\"";
            }
        }

        public class Number : IJsonValue
        {
            private readonly string _input;
            public Number(string propertyName, string input)
            {
                _input = input;
                PropertyName = propertyName;
            }
            public string PropertyName { get; set; }
            public string GetJsonRepresentation()
            {
                return $"{_input}";
            }
        }

        public class Bool : Number
        {
            public Bool(string propertyName, string input) : base(propertyName, input) {}
        }

        public class Null : IJsonValue
        {
            public Null(string propertyName)
            {
                PropertyName = propertyName;
            }
            public string PropertyName { get; set; }
            public string GetJsonRepresentation()
            {
                return $"null";
            }
        }

        public class NotPresent : IJsonValue
        {
            public NotPresent(string propertyName)
            {
                PropertyName = propertyName;
            }
            public string PropertyName { get; set; }
            public string GetJsonRepresentation()
            {
                throw new NotImplementedException("Do not get representation of class JsonDoc.NotPresent");
            }
        }

        public static async Task Assert<TModel, TProperty>(IJsonValue input, Func<TModel, TProperty> toProperty, TProperty shouldBe)
        {
            HttpResponseMessage response;
            if (input is NotPresent)
            {
                response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("{}", Encoding.UTF8, "application/json")
                };
            }
            else
            {
                var jsonContent = $@"{{
                    ""{input.PropertyName}"": {input.GetJsonRepresentation()}
                }}";

                response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
                };
            }
            
            response.EnsureSuccessStatusCode();
            
            var deserializer = new CustomJsonCodec(new Configuration());
            var output = await deserializer.Deserialize<TModel>(response);

            Xunit.Assert.Equal(shouldBe, toProperty(output));
        }
    }
}