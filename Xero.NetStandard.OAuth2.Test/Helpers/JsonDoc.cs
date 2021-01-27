using System;
using RestSharp;
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

        public static void Assert<TModel, TProperty>(IJsonValue input, Func<TModel, TProperty> toProperty, TProperty shouldBe)
        {
            var response = new RestResponse();

            if (input is NotPresent)
            {
                response.Content = "{}";
            }
            else
            {
                response.Content = $@"{{
                    ""{input.PropertyName}"": {input.GetJsonRepresentation()}
                }}";
            }

            var deserializer = new CustomJsonCodec(new Configuration());
            var output = deserializer.Deserialize<TModel>(response);
            Xunit.Assert.Equal(shouldBe, toProperty(output));
        }
    }
}