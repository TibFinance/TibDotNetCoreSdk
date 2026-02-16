
using System;
using Tib.Api.Model.ConvenientFee;
using Tib.Api.Common;

namespace Tib.Api.Model.ConvenientFee
{
    /// <summary>
    /// Represents the AddOrUpdateConvenientFeeSettingsForMerchantArgs model.
    /// </summary>
    public class AddOrUpdateConvenientFeeSettingsForMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ConvenientFeeSettingsModel ConvenientFeeSettings { get; set; }

    }
}