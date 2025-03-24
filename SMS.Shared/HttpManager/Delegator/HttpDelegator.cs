using SMS.Shared.JWTToken;
using SMS.Shared.Loader;
using System.Net.Http.Headers;

namespace SMS.Shared.HttpManager.Delegator
{
    public class HttpDelegator: DelegatingHandler
    {
        private readonly LoaderService _loaderService;
        private readonly ITokenService _tokenService;


        public HttpDelegator(LoaderService loaderService, ITokenService tokenService)
        {
            _loaderService = loaderService;
            _tokenService = tokenService;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            _loaderService.ShowLoader();

            try
            {
                string token = await _tokenService.GetUserToken();
                if (!string.IsNullOrEmpty(token))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                HttpResponseMessage response = await base.SendAsync(request, cancellationToken); 
                return response;
            }
            finally
            {
                _loaderService.HideLoader();
            }

        }

    }
}
