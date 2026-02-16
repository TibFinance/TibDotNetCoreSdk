
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetFeesOverloadMerchantResponse model.
    /// </summary>
    public class GetFeesOverloadMerchantResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? FeesOverLoadMerchantId { get; set; }

    }
}