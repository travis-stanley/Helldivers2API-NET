using System;

namespace Helldivers2API.Web
{
  internal class WarStatsRequest : RequestParams
  {
    /// <summary>
    /// WarStats request
    /// </summary>
    /// <param name="warId">
    /// The war id, aka season.
    /// </param>
    public WarStatsRequest(int warId)
    {
      Ensure.ArgumentNotNull(warId, nameof(warId));

      WarId = warId;
    }

    public int WarId { get; set; }

  }
}

