using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data.Interfaces.Message;
using SMS.DataAccess.Models.Chat.Request;
using SMS.DataAccess.Models.Chat.Response;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.HttpManager.Utility;
using SMS.Shared.Static.Routes;

namespace SMS.DataAccess.Data.Implementations.Message
{
    public class Message : IMessage
    {
        private readonly IHttpClientManager _httpClientManager;
        private readonly string _APIConnection;

        public Message(IConfiguration config, IHttpClientManager httpClientManager)
        {
            _httpClientManager = httpClientManager;
            _APIConnection = AppSettingsConfig.GetConnectionString(config);
        }

        public async Task<HttpResponseDTO<IEnumerable<ParentMessageModel>>> GetParentMessageListAsync(ChatListReq filters)
        {
            HttpResponseDTO<IEnumerable<ParentMessageModel>> responseVM = await _httpClientManager.GetAsync<IEnumerable<ParentMessageModel>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Message.ParentMessageList, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(filters));
            return responseVM;
        }

        public async Task<HttpResponseDTO<List<MessageModel>>> GetChatMessageAsync(ChatListReq filters)
        {
            HttpResponseDTO<List<MessageModel>> responseVM = await _httpClientManager.GetAsync<List<MessageModel>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Message.ChatData, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(filters));
            return responseVM;
        }
    }
}
