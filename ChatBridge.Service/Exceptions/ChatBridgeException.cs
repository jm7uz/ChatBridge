using Microsoft.AspNetCore.Http;

namespace ChatBridge.Service.Exceptions;

public class ChatBridgeException : Exception
{
    public int StatusCode { get; set; }

    public ChatBridgeException(int code, string message) : base(message)
    {
        StatusCode = code;
    }
}

