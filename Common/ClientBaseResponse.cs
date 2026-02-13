using System.Collections.Generic;
using Tib.Api.CryptedService;

namespace Tib.Api.Common
{
  /// <summary>
  /// base Response for the Api Calls . 
  /// </summary>
  public class ClientBaseResponse
  {
    /// <summary>
    /// list of errors that came from the Api 
    /// </summary>
    public List<BaseServiceError> Errors { get; set; }
    /// <summary>
    /// Boolean to tell if there is a error or not
    /// </summary>
    public bool HasError { get; set; }
    /// <summary>
    ///  a message that comes with the error 
    /// </summary>
    public string Messages { get; set; }
  }
}
