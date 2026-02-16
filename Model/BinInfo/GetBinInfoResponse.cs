
using System;
using Tib.Api.Model.BinInfo;
using Tib.Api.Common;

namespace Tib.Api.Model.BinInfo
{
    /// <summary>
    /// Represents the GetBinInfoResponse model.
    /// </summary>
    public class GetBinInfoResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public BinInfoDto BinInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool Found { get; set; }

    }
}