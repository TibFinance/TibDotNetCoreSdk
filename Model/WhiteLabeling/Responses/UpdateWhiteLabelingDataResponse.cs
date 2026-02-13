using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Responses
{
  /// <summary>
  ///  the response of Updating the Whitelabeling.
  /// </summary>
  public class UpdateWhiteLabelingDataResponse : ClientBaseResponse
  {
    /// <summary>
    /// the Updated Version of the Whitelabeling.
    /// </summary>
    public WhiteLabelingModel WhiteLabeling { get; set; }
  }
}
