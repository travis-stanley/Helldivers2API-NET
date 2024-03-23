using System;

namespace Helldivers2API.Web
{
  internal class AssignmentRequest : RequestParams
  {
    /// <summary>
    /// Assignment request
    /// </summary>
    /// <param name="warId">
    /// The war id, aka season.
    /// </param>
    public AssignmentRequest(int warId)
    {
      Ensure.ArgumentNotNull(warId, nameof(warId));

      WarId = warId;
    }

    public int WarId { get; set; }

  }
}

