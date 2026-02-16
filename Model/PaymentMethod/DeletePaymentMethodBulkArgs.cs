
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the DeletePaymentMethodBulkArgs model.
    /// </summary>
    public class DeletePaymentMethodBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> PaymentMethodIds { get; set; }

    }
}