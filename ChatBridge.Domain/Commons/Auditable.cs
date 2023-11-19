namespace ChatBridge.Domain.Commons;

public abstract class Auditable
{
    public int Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? LastUpdatedAt { get; set;} 
    public DateTime? LastCreateBy { get; set;}
    public DateTime? LastUpdatedBy { get; set; }
}
