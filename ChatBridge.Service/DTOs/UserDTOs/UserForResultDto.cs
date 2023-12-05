using ChatBridge.Domain.Entities;
using ChatBridge.Domain.Enums;

namespace ChatBridge.Service.DTOs.UserDTOs;

public class UserForResultDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? UserName { get; set; }
    public string PhoneNumber { get; set; }
    public Role Role { get; set; }

    public ICollection<UserAsset> UserAsset { get; set; }
}
