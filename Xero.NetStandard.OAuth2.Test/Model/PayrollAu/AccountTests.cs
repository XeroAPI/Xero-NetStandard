/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Net;
using System.Net.Http;
using Xero.NetStandard.OAuth2.Model.PayrollAu;
using Xero.NetStandard.OAuth2.Client;
using System.Text;
using System.Threading.Tasks;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing Account
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccountTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'AccountID' only deserialises from valid GUID
        /// </summary>
        [Fact]
        public async Task AccountID_ValidInput_Deserialises()
        {
            string jsonContent = @"{
                ""AccountID"": ""12345678-abcd-abcd-abcd-1234567890ab""
            }";
            
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
            
            response.EnsureSuccessStatusCode();
            
            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = await deserializer.Deserialize<Account>(response);

            Assert.Equal(new Guid("12345678-abcd-abcd-abcd-1234567890ab"), actual.AccountID);
        }
        /// <summary>
        /// Test the property 'AccountID' fails to deserialise from invalid value
        /// </summary>
        [Fact]
        public async Task AccountID_InvalidInput_ThrowsApiException()
        {
            string jsonContent = @"{
                ""AccountID"": ""12345678-abcd-abcd-abcd-invalidvalue""
            }";
            
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
            
            response.EnsureSuccessStatusCode();

            var deserializer = new CustomJsonCodec(new Configuration());
            
                await Assert.ThrowsAsync<ApiException>(async () =>
    {
        var account = await deserializer.Deserialize<Account>(response);
    });
        }
        
        /// <summary>
        /// Test the property 'Type' deserialises correctly from valid inputs
        /// </summary>
        [Theory]
        [InlineData("BANK", AccountType.BANK)]
        [InlineData("CURRENT", AccountType.CURRENT)]
        [InlineData("CURRLIAB", AccountType.CURRLIAB)]
        [InlineData("DEPRECIATN", AccountType.DEPRECIATN)]
        [InlineData("DIRECTCOSTS", AccountType.DIRECTCOSTS)]
        [InlineData("EQUITY", AccountType.EQUITY)]
        [InlineData("EXPENSE", AccountType.EXPENSE)]
        [InlineData("FIXED", AccountType.FIXED)]
        [InlineData("INVENTORY", AccountType.INVENTORY)]
        [InlineData("LIABILITY", AccountType.LIABILITY)]
        [InlineData("NONCURRENT", AccountType.NONCURRENT)]
        [InlineData("OTHERINCOME", AccountType.OTHERINCOME)]
        [InlineData("OVERHEADS", AccountType.OVERHEADS)]
        [InlineData("PREPAYMENT", AccountType.PREPAYMENT)]
        [InlineData("REVENUE", AccountType.REVENUE)]
        [InlineData("SALES", AccountType.SALES)]
        [InlineData("TERMLIAB", AccountType.TERMLIAB)]
        [InlineData("PAYGLIABILITY", AccountType.PAYGLIABILITY)]
        [InlineData("PAYG", AccountType.PAYG)]
        [InlineData("SUPERANNUATIONEXPENSE", AccountType.SUPERANNUATIONEXPENSE)]
        [InlineData("SUPERANNUATIONLIABILITY", AccountType.SUPERANNUATIONLIABILITY)]
        [InlineData("WAGESEXPENSE", AccountType.WAGESEXPENSE)]
        [InlineData("WAGESPAYABLELIABILITY", AccountType.WAGESPAYABLELIABILITY)]
        public async Task Type_ValidInput_Deserialises(string input, AccountType expected)
        {
            var jsonContent = $@"{{
                ""Type"": ""{input}""
            }}";
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
            response.EnsureSuccessStatusCode();
            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = await deserializer.Deserialize<Account>(response);
            Assert.Equal(expected, actual.Type);
        }
        /// <summary>
        /// Test the property 'Type' deserialises correctly from 'null'
        /// </summary>
        [Fact]
        public async Task Type_NullInput_DeserialisesTo0()
        {
            string jsonContent = @"{
                ""Type"": null
            }";
            
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
            
            response.EnsureSuccessStatusCode();
            
            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = await deserializer.Deserialize<Account>(response);

            Assert.Equal(0, (int)actual.Type);
        }
        /// <summary>
        /// Test the property 'Type' deserialises correctly from no input
        /// </summary>
        [Fact]
        public async Task Type_NotPresentInInput_DeserialisesTo0()
        {
            var jsonContent = "{}";
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
            response.EnsureSuccessStatusCode();
            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = await deserializer.Deserialize<Account>(response);
            Assert.Equal(0, (int) actual.Type);
        }
    }

}
