using SMS.DataAccess.Models.Chat.Request;
using SMS.DataAccess.Models.Chat.Response;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.Message
{
    public interface IMessage
    {
        Task<HttpResponseDTO<IEnumerable<ParentMessageModel>>> GetParentMessageListAsync(ChatListReq filters);
        Task<HttpResponseDTO<List<MessageModel>>> GetChatMessageAsync(ChatListReq filters);
    }
}
