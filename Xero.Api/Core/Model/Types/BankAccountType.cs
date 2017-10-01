﻿using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum BankAccountType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "BANK")]
        Bank,
        [EnumMember(Value = "CREDITCARD")]
        CreditCard,
        [EnumMember(Value = "PAYPAL")]
        Paypal,
        [EnumMember(Value = "NONE")]
        None,
    }
}
