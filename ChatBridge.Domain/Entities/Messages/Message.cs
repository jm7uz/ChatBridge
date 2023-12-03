using ChatBridge.Domain.Commons;
using ChatBridge.Domain.Enums;

namespace ChatBridge.Domain.Entities.Messages;

public class Message : Auditable
{
    public long? ParentId { get; set; }
    public Message Parent { get; set; }
    public long FromId { get; set; }
    public User From { get; set; }
    public long ToId { get; set; }
    public User To { get; set; }
    public MessageType Type { get; set; }
    public FormatType FormatType { get; set; }
}
