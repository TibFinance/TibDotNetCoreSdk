
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the BlueSnapWebhookArgs model.
    /// </summary>
    public class BlueSnapWebhookArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TransactionType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Dictionary<string, string> WebhookDatas { get; set; }

    }
}