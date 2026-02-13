using System;

namespace Tib.Api.Common
{
  /// <summary>
  ///  the base Object for the api calls Arguments . 
  /// </summary>
  public class ClientCallBaseArgs
  {
    /// <summary>
    /// Session ID obtained by calling the CreateSession method
    /// </summary>
    public Guid? SessionToken { get; set; }
  }
}
