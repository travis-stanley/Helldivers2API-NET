using System;

namespace Helldivers2API.Web
{
  public class WarFeedRequest : RequestParams
  {
    /// <summary>
    /// WarFeed request
    /// </summary>
    /// <param name="warId">
    /// The war id, aka season.
    /// </param>
    public WarFeedRequest(int warId)
    {
      Ensure.ArgumentNotNull(warId, nameof(warId));

      WarId = warId;
    }

    public int WarId { get; set; }

  }
}

