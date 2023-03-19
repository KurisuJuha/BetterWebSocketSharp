using WebSocketSharpServer = WebSocketSharp.Server.WebSocketServer;

namespace JuhaKurisu.BetterWebSocketSharp;

public class WebSocketServer
{
    public readonly int port;
    private WebSocketSharpServer sharpServer;

    public WebSocketServer(int port)
    {
        this.port = port;
        sharpServer = new WebSocketSharpServer(port);
        sharpServer.AllowForwardedRequest = true;
    }
}