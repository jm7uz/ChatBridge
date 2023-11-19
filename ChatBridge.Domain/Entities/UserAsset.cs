namespace ChatBridge.Domain.Entities;

public class UserAsset : Asset
{
    public long? UserId { get; set; }
    public User User { get; set; }
}
