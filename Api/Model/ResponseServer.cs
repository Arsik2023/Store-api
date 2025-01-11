using System.Net;

namespace Api;

public class ResponseServer
{
    public ResponseServer()
    {
        this.IsSucces = true;
        this.ErrorMessages = new();
    }

    public bool IsSucces { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public List<string> ErrorMessages { get; set; }
    public object Result { get; set; }
}
