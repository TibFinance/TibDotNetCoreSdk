
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetAcpTypesArgs model.
    /// </summary>
    public class GetAcpTypesArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Client information to modify
    /// </summary>
    /// <value>The client.</value>
    public Guid RelatedId { get; set; }

    }
}