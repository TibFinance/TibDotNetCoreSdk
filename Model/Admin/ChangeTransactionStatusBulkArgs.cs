
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the ChangeTransactionStatusBulkArgs model.
    /// </summary>
    public class ChangeTransactionStatusBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> TransactionIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int TransactionStatus { get; set; }

    }
}