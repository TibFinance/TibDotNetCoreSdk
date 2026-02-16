
using System;
using Tib.Api.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the GetBlueSnapTokenResponse model.
    /// </summary>
    public class GetBlueSnapTokenResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public GetBlueSnapClientTokenResponse GetBlueSnapClientTokenResponse { get; set; }

    }
}