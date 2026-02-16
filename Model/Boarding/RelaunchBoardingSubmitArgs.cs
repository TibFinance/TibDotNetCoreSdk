
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the RelaunchBoardingSubmitArgs model.
    /// </summary>
    public class RelaunchBoardingSubmitArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid BoardingInfoId { get; set; }

    }
}