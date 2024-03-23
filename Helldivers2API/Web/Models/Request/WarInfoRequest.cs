using System;

namespace Helldivers2API.Web
{
  internal class WarInfoRequest : RequestParams
  {
    /// <summary>
    /// WarInfo request
    /// </summary>
    /// <param name="warId">
    /// The war id, aka season.
    /// </param>
    public WarInfoRequest(int warId)
    {
      Ensure.ArgumentNotNull(warId, nameof(warId));

      WarId = warId;
    }

    public int WarId { get; set; }

  }
}

