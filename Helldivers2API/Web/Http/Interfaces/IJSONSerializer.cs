namespace Helldivers2API.Web.Http
{
  internal interface IJSONSerializer
  {
    void SerializeRequest(IRequest request);
    IAPIResponse<T> DeserializeResponse<T>(IResponse response);
  }
}
