
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetCustomerServiceCurrenctResponse model.
    /// </summary>
    public class GetCustomerServiceCurrenctResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public int Currency { get; set; }

    }
}