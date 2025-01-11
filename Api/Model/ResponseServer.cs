using System.Net;

namespace Api;

public class ResponseServer
{
    public ResponseServer()
    {
        this.IsSucces = true;
        this.ErrorMessage = new();
    }

    public bool IsSucces { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public List<string> ErrorMessage { get; set; }
    public object Result { get; set; }
}
