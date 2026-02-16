
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the DeleteLoginRelationResponse model.
    /// </summary>
    public class DeleteLoginRelationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid LoginRelationId { get; set; }

    }
}