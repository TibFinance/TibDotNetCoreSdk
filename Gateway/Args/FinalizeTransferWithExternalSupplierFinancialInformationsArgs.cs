
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the FinalizeTransferWithExternalSupplierFinancialInformationsArgs model.
    /// </summary>
    public class FinalizeTransferWithExternalSupplierFinancialInformationsArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool SupplierAccountAlreadyExists { get; set; }

    /// <summary>
    /// Contains the necessary details for replacing a merchant's account information within the system.
    /// </summary>
    /// <value>This model represents the account details associated with a merchant, ensuring that all relevant information is accurately captured and stored.</value>
    public AccountModel Account { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? CustomerConsent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool PreAuthorizationGivenForThisMerchant { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool PreAuthorizationGivenForAllMerchants { get; set; }

    }
}