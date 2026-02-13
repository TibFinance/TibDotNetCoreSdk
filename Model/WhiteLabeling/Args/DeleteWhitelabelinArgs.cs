using System;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Args
{
  /// <summary>
  /// Object to delete a whitelabeling 
  /// </summary>
  public class DeleteWhitelabelinArgs : ClientCallBaseArgs
  {
    /// <summary>
    ///  Set or get the Id Of the Entity to delete the whitelabeling of
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    ///  the Level Of the Entity that was Whitelabeled (Merchant, Service, Client).
    /// </summary>
    public int Level { get; set; }
  }
}
