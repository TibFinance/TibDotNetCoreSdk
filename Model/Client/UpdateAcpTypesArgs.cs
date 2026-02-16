
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the UpdateAcpTypesArgs model.
    /// </summary>
    public class UpdateAcpTypesArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Source { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid SourceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? CollectMerchantCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? DepositClientCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? CollectClientCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? DepositMerchantCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? FeesmerchantCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? TibFeesCode { get; set; }

    }
}