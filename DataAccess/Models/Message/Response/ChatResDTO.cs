namespace SMS.DataAccess.Models.Chat.Response
{
    public class MessageResponseDTO
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
        public bool IsSeen { get; set; }
        public DateTime SendDate { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public int ParentMessageId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public bool IsEventChat { get; set; }
        public string? EventName { get; set; }
        public bool IsExpanded { get; set; } = false;
    }

    public class ParentMessageModel
    {
        public int MessageId { get; set; }
        public string Topic { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
        public int UnreadCount { get; set; }
        public string? UserPhoto { get; set; }
    }

    public class MessageModel
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
        public bool IsSeen { get; set; }
        public DateTime SendDate { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public int ParentMessageId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public bool IsEventChat { get; set; }
        public string? EventName { get; set; }
    }
}
