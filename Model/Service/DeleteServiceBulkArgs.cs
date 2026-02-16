
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the DeleteServiceBulkArgs model.
    /// </summary>
    public class DeleteServiceBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> ServiceIds { get; set; }

    }
}