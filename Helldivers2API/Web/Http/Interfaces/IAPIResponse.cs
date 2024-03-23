namespace Helldivers2API.Web.Http
{
  internal interface IAPIResponse<out T>
  {
    T? Body { get; }

    IResponse Response { get; }
  }
}
