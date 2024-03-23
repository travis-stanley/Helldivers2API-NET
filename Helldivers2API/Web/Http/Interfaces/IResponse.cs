using System.Collections.Generic;
using System.Net;

namespace Helldivers2API.Web.Http
{
  internal interface IResponse
  {
    object? Body { get; }

    IReadOnlyDictionary<string, string> Headers { get; }

    HttpStatusCode StatusCode { get; }

    string? ContentType { get; }
  }
}
