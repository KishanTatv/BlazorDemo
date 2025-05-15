using Microsoft.AspNetCore.SignalR.Client;
using SMS.DataAccess.Models.Chat.Request;
using SMS.DataAccess.Models.Chat.Response;
using SMS.Shared.JWTToken;

namespace BlazorApp.Client.Services
{
    public class SignalRService
    {
        private HubConnection _hubConnection = default!;
        private readonly ITokenService _tokenService;
        private bool _isSubscribed = false;

        public event Action<MessageResponseDTO>? MessageReceived;
        public event Action<int>? MessageReadMark;
        public event Action<int>? MessageChatEnd;

        public SignalRService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public async Task InitilizeSignalR()
        {
            var token = await _tokenService.GetUserToken();
            if(_hubConnection == null)
            {
                _hubConnection = new HubConnectionBuilder()
                    .WithUrl($"https://localhost:7057/signalRHub?token={token}")
                    .WithAutomaticReconnect()
                    .Build();
                await StartConnectionAsync();
            }
            if(!_isSubscribed)
            {
                ListenHandler();
                _isSubscribed = true;
            }
        }

        public async Task StartConnectionAsync()
        {
            if (_hubConnection.State != HubConnectionState.Connected)
            {
                await _hubConnection.StartAsync();                                                            
            }
        }

        public async Task StopConnectionAsync()
        {
            if (_hubConnection.State == HubConnectionState.Connected)
            {
                await _hubConnection.StopAsync();
            }
        }

        public async Task SendMessage(NewMessageDTO newMessageDTO)
        {
            await StartConnectionAsync();
            await _hubConnection.InvokeAsync("SendMessageToUser", newMessageDTO);
        }

        public async Task ReadAllMessage(ReadMessageDTO readMessageReq)
        {
            await StartConnectionAsync();
            await _hubConnection.InvokeAsync("readAllMessages", readMessageReq);
        }

        public async Task EndChat(ReadMessageDTO messageReq)
        {
            await StartConnectionAsync();
            await _hubConnection.InvokeAsync("EndConversation", messageReq);
        }

        public void ListenHandler()
        {
            _hubConnection.On<MessageResponseDTO>("ReceiveMessage", (msg) =>
            {
                MessageReceived?.Invoke(msg);
            });
            _hubConnection.On<int>("MessageSeen", (parentMessageId) =>
            {
                MessageReadMark?.Invoke(parentMessageId);
            });
            _hubConnection.On<int>("ReceiveEndConversation", (parentMessageId) =>
            {
                MessageChatEnd?.Invoke(parentMessageId);
            });
        }

    }
}
