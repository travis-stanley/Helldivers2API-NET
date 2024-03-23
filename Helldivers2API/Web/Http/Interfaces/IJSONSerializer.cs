namespace Helldivers2API.Web.Http
{
  public interface IJSONSerializer
  {
    void SerializeRequest(IRequest request);
    IAPIResponse<T> DeserializeResponse<T>(IResponse response);
  }
}
