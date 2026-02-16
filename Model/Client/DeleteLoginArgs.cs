
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the DeleteLoginArgs model.
    /// </summary>
    public class DeleteLoginArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid LoginId { get; set; }

    }
}