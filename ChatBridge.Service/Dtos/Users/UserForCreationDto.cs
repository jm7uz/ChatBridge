namespace ChatBridge.Service.Dtos.Users;

public class UserForCreationDto
{
    public string Firstname { get; set; }
    public string Lastname { get; set; } = string.Empty;
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}
