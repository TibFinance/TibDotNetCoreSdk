
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the RelaunchOperationBulkArgs model.
    /// </summary>
    public class RelaunchOperationBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> OperationIds { get; set; }

    }
}