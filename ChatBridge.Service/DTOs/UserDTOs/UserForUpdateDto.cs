using ChatBridge.Domain.Enums;

namespace ChatBridge.Service.DTOs.UserDTOs;

public class UserForUpdateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string PhoneNumber { get; set; }
}
