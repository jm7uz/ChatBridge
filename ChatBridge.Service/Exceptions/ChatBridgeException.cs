namespace ChatBridge.Service.Exceptions;

public class ChatBridgeException : Exception
{
    readonly int _status;
    public ChatBridgeException(int status, string message ) : base(message)
    {
        _status = status;
    }
}
