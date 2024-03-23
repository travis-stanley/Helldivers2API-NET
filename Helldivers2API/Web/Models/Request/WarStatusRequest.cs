using System;

namespace Helldivers2API.Web
{
  internal class WarStatusRequest : RequestParams
  {
    /// <summary>
    /// WarStatus request
    /// </summary>
    /// <param name="warId">
    /// The war id, aka season.
    /// </param>
    public WarStatusRequest(int warId)
    {
      Ensure.ArgumentNotNull(warId, nameof(warId));

      WarId = warId;
    }

    public int WarId { get; set; }

  }
}

