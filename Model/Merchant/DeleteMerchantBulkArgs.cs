
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the DeleteMerchantBulkArgs model.
    /// </summary>
    public class DeleteMerchantBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> MerchantIds { get; set; }

    }
}