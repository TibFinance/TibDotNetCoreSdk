
using System;
using System.Collections.Generic;
using Tib.Api.CryptedService;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the CreateBoardingClientArgs model.
    /// </summary>
    public class CreateBoardingClientArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the name of the sub-client.
    /// </summary>
    /// <value>Specifies the name associated with the sub-client.</value>
    public String Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String Email { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String PhoneNumber { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public int Language { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public int Currency { get; set; }

    }
}