using ChatBridge.Domain.Entities;
using ChatBridge.Domain.Enums;

namespace ChatBridge.Service.DTOs.UserDTOs;

public class UserForCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? UserName { get; set; }
    public string PhoneNumber { get; set; }
}
