
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the DeleteCustomerBulkArgs model.
    /// </summary>
    public class DeleteCustomerBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> CustomerIds { get; set; }

    }
}