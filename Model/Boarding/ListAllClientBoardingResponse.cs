
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the ListAllClientBoardingResponse model.
    /// </summary>
    public class ListAllClientBoardingResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public IEnumerable<object> List { get; set; }

    }
}