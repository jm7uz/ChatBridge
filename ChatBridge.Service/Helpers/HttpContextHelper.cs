using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Security.Claims;

namespace ChatBridge.Service.Helpers;

public class HttpContextHelper
{
    private static long _tempUserId;

    public static IHttpContextAccessor Accessor { get; set; }
    public static HttpContext HttpContext => Accessor?.HttpContext;
    public static IHeaderDictionary ResponseHeaders => HttpContext?.Response?.Headers;
    public static long? UserId => long.TryParse(HttpContext?.User?.FindFirst("id")?.Value, out _tempUserId) ? _tempUserId : (long?)null;
    public static string UserRole => HttpContext?.User?.FindFirst(ClaimTypes.Role)?.Value;
}
