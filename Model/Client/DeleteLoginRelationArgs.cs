
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the DeleteLoginRelationArgs model.
    /// </summary>
    public class DeleteLoginRelationArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid LoginRealtionId { get; set; }

    }
}