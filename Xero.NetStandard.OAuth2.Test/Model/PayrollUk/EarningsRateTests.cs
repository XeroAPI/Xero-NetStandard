using System;
using Xero.NetStandard.OAuth2.Model.PayrollUk;
using Xunit;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollUk
{
    public class EarningsRateTests : IDisposable
    {
        public EarningsRateTests()
        {
            // TODO uncomment below to create an instance of EarningsRate
            //instance = new EarningsRate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'EarningsType'
        /// </summary>
        [Theory]
        [InlineData("Allowance", EarningsRate.EarningsTypeEnum.Allowance)]
        [InlineData("Backpay", EarningsRate.EarningsTypeEnum.Backpay)]
        [InlineData("Bonus", EarningsRate.EarningsTypeEnum.Bonus)]
        [InlineData("Commission", EarningsRate.EarningsTypeEnum.Commission)]
        [InlineData("LumpSum", EarningsRate.EarningsTypeEnum.LumpSum)]
        [InlineData("OtherEarnings", EarningsRate.EarningsTypeEnum.OtherEarnings)]
        [InlineData("OvertimeEarnings", EarningsRate.EarningsTypeEnum.OvertimeEarnings)]
        [InlineData("RegularEarnings", EarningsRate.EarningsTypeEnum.RegularEarnings)]
        [InlineData("StatutoryAdoptionPay", EarningsRate.EarningsTypeEnum.StatutoryAdoptionPay)]
        [InlineData("StatutoryMaternityPay", EarningsRate.EarningsTypeEnum.StatutoryMaternityPay)]
        [InlineData("StatutoryPaternityPay", EarningsRate.EarningsTypeEnum.StatutoryPaternityPay)]
        [InlineData("StatutorySharedParentalPay", EarningsRate.EarningsTypeEnum.StatutorySharedParentalPay)]
        [InlineData("StatutorySickPay", EarningsRate.EarningsTypeEnum.StatutorySickPay)]
        [InlineData("Tips(Direct)", EarningsRate.EarningsTypeEnum.TipsDirect)]
        [InlineData("Tips(Non-Direct)", EarningsRate.EarningsTypeEnum.TipsNonDirect)]
        [InlineData("Statutory Adoption Pay (Non Pensionable)", EarningsRate.EarningsTypeEnum.StatutoryAdoptionPayNonPensionable)]
        [InlineData("Statutory Maternity Pay (Non Pensionable)", EarningsRate.EarningsTypeEnum.StatutoryMaternityPayNonPensionable)]
        [InlineData("Statutory Paternity Pay (Non Pensionable)", EarningsRate.EarningsTypeEnum.StatutoryPaternityPayNonPensionable)]
        [InlineData("Statutory Parental Bereavement Pay (Non Pensionable)", EarningsRate.EarningsTypeEnum.StatutoryParentalBereavementPayNonPensionable)]
        [InlineData("Statutory Shared Parental Pay (Non Pensionable)", EarningsRate.EarningsTypeEnum.StatutorySharedParentalPayNonPensionable)]
        [InlineData("Statutory Sick Pay (Non Pensionable)", EarningsRate.EarningsTypeEnum.StatutorySickPayNonPensionable)]
        public void EarningsTypeTest(string input, EarningsRate.EarningsTypeEnum expected)
        {
            JsonDoc.Assert<EarningsRate, EarningsRate.EarningsTypeEnum>(
                input: new JsonDoc.String(nameof(EarningsRate.EarningsType), input),
                toProperty: e => e.EarningsType,
                shouldBe: expected
            );
        }
    }
}
