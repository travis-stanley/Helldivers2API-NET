namespace Helldivers2API.Web.Http
{
  internal class APIResponse<T> : IAPIResponse<T>
  {
    public APIResponse(IResponse response, T? body = default)
    {
      Ensure.ArgumentNotNull(response, nameof(response));

      Body = body;
      Response = response;
    }

    public T? Body { get; set; }

    public IResponse Response { get; set; }
  }
}
