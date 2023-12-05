using ChatBridge.Domain.Entities;
using ChatBridge.Domain.Enums;
using ChatBridge.Service.Dtos.UserAssets;

namespace ChatBridge.Service.Dtos.Users;

public class UserForResultDto
{
    public Role Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string PhoneNumber { get; set; }
    public UserAssetForResultDto? UserAsset { get; set; }
}
