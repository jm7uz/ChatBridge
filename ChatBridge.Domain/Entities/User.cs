using ChatBridge.Domain.Enums;
using ChatBridge.Domain.Commons;

namespace ChatBridge.Domain.Entities;

public class User : Auditable
{
    public Role Role { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public string PhoneNumber { get; set; }
    public UserAsset UserAsset { get; set; }

}
