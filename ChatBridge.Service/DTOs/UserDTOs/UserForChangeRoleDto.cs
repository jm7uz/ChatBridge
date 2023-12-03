using ChatBridge.Domain.Enums;

namespace ChatBridge.Service.DTOs.UserDTOs;

public class UserForChangeRoleDto
{
    public long Id { get; set; }
    public Role Role { get; set; }
}
