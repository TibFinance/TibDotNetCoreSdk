
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the EditAuthorizationStatusResponse model.
    /// </summary>
    public class EditAuthorizationStatusResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AuthorizationStatus { get; set; }

    }
}