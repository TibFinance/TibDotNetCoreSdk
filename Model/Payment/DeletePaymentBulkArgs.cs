
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the DeletePaymentBulkArgs model.
    /// </summary>
    public class DeletePaymentBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> PaymentIds { get; set; }

    }
}