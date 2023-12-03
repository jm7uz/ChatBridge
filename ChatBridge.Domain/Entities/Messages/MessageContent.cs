using ChatBridge.Domain.Commons;
using ChatBridge.Domain.Enums;

namespace ChatBridge.Domain.Entities.Messages;

public class MessageContent : Auditable
{
    public byte[] Content { get; set; }
    public MessageType ContentType { get; set; }
    public long MessageId { get; set; }
    public Message Message { get; set; }
}
