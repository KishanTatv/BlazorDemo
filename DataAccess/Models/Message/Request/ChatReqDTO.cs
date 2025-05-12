namespace SMS.DataAccess.Models.Chat.Request
{
    public class NewMessageDTO
    {
        public string Message { get; set; }
        public int SenderId { get; set; } = 1;
        public int ParentMessageId { get; set; }
    }

    public class ChatListReq
    {
        public int UserId { get; set; }
        public bool GetArchived { get; set; } = false;
        public int ParentMessageId { get; set; }
    }

    public class ReadMessageDTO
    {
        public int ReceiverId { get; set; }
        public int SenderId { get; set; }
        public int ParentMessageId { get; set; }
    }
}
