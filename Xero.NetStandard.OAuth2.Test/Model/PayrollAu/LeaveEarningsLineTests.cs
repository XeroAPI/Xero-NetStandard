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
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollAu;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing LeaveEarningsLine
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LeaveEarningsLineTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }
        /// <summary>
        /// Test the property 'RatePerUnit'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task RatePerUnitTest(string input)
        {
            await JsonDoc.Assert<LeaveEarningsLine, decimal?>(
                input: new JsonDoc.Number(nameof(LeaveEarningsLine.RatePerUnit), input),
                toProperty: x => x.RatePerUnit,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'NumberOfUnits'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task NumberOfUnitsTest(string input)
        {
            await JsonDoc.Assert<LeaveEarningsLine, decimal?>(
                input: new JsonDoc.Number(nameof(LeaveEarningsLine.NumberOfUnits), input),
                toProperty: x => x.NumberOfUnits,
                shouldBe: 20
            );
        }
    }
}
