using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;

namespace Helldivers2API.Web.Http
{
  internal class Response : IResponse
  {
    public Response(IDictionary<string, string> headers)
    {
      Ensure.ArgumentNotNull(headers, nameof(headers));

      Headers = new ReadOnlyDictionary<string, string>(headers);
    }

    public object? Body { get; set; }

    public IReadOnlyDictionary<string, string> Headers { get; set; }

    public HttpStatusCode StatusCode { get; set; }

    public string? ContentType { get; set; }
  }
}
