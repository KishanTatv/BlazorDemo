using Blazored.LocalStorage;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SMS.Shared.JWTToken
{

    public class TokenService : ITokenService
    {
        private JwtDTO? _tokenData;

        public static readonly string TOKEN_KEY = "token";
        public static readonly string REFRESH_TOKEN_KEY = "refreshToken";
        private readonly ILocalStorageService _localStorage;
        public TokenService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public JwtDTO? TokenData => _tokenData;

        public async Task StoreTokensAsync(string accessToken, string refreshToken)
        {
            await _localStorage.SetItemAsync(TOKEN_KEY, accessToken);
            await _localStorage.SetItemAsync(REFRESH_TOKEN_KEY, refreshToken);
        }

        public async Task RemoveTokensAsync()
        {
            await _localStorage.RemoveItemAsync(TOKEN_KEY);
            await _localStorage.RemoveItemAsync(REFRESH_TOKEN_KEY);
        }

        public async Task<string> GetUserToken()
        {
            string? token = await _localStorage.GetItemAsync<string>(TOKEN_KEY);
            return await _localStorage.GetItemAsync<string>(TOKEN_KEY) ?? string.Empty;
        }

        public async Task<JwtDTO?> GetClaimFromToken()
        {

            if (_tokenData == null)
            {
                var token = await GetUserToken();
                if (string.IsNullOrWhiteSpace(token) || string.IsNullOrEmpty(token))
                {
                    return null;
                }
                JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();
                if (!jwtHandler.CanReadToken(token))
                {
                    return null;
                }
                IEnumerable<Claim> claim = jwtHandler.ReadJwtToken(token).Claims;
                JwtDTO jwtData = new JwtDTO()
                {
                    role = int.Parse(claim?.FirstOrDefault(c => c.Type == "role").Value),
                    CurrentYearId = int.Parse(claim?.FirstOrDefault(c => c.Type == "CurrentYearId").Value),
                    UserId = int.Parse(claim?.FirstOrDefault(c => c.Type == "UserId").Value),
                };
                _tokenData = jwtData;
            }
            return _tokenData;
        }

        public void SetTokenData(JwtDTO token)
        {
            _tokenData = token;
        }

        public async Task<bool> IsTokenValid()
        {
            var token = await GetUserToken();
            if(!string.IsNullOrEmpty(token))
            {
                if (new JwtSecurityTokenHandler().ReadJwtToken(token).ValidTo <= DateTime.UtcNow)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
