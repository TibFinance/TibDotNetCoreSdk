
using System;
using System.Collections.Generic;
using Tib.Api.Model.Report;
using Tib.Api.Common;

namespace Tib.Api.Model.Report
{
    /// <summary>
    /// Represents the GetFeesReportResponse model.
    /// </summary>
    public class GetFeesReportResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the list of individual fee line items.
    /// </summary>
    /// <value></value>
    public List<FeeReportLineItem> FeeItems { get; set; }

    /// <summary>
    /// Gets or sets the summary statistics for the fees.
    /// </summary>
    /// <value></value>
    public FeeSummary Summary { get; set; }

    }
}