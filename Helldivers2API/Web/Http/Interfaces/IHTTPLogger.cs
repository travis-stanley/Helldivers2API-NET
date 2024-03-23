namespace Helldivers2API.Web.Http
{
  internal interface IHTTPLogger
  {
    void OnRequest(IRequest request);
    void OnResponse(IResponse response);
  }
}
