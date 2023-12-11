using ChatBridge.Domain.Enums;

namespace ChatBridge.Service.Dtos.Users;

public class UserForCreationDto
{
    public Role Role { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
}
