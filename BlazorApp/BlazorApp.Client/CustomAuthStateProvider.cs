using Microsoft.AspNetCore.Components.Authorization;
using SMS.Shared.JWTToken;
using SMS.Shared.Static.Enum;
using System.Security.Claims;

namespace BlazorApp
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ITokenService _tokenService;
        public CustomAuthStateProvider(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var tokenResult = await _tokenService.GetClaimFromToken();
            var identity = new ClaimsIdentity();
            if (tokenResult != null)
            {
                identity = new ClaimsIdentity(
                    new[] {
                        new Claim(ClaimTypes.Name, tokenResult.UserName),
                        new Claim(ClaimTypes.Role, ((Roles)tokenResult.role).ToString()),
                        new Claim(ClaimTypes.Email, tokenResult.Email),
                        new Claim("UserId", tokenResult.UserId.ToString()),
                    }, "Custom Authentication"
                );
            }
            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        public async Task NotifyUserAuthentication()
        {
            var tokenResult = await _tokenService.GetClaimFromToken();
            var identity = new ClaimsIdentity();
            if (tokenResult != null)
            {
                identity = new ClaimsIdentity(
                    new[] {
                        new Claim(ClaimTypes.Name, tokenResult.UserName),
                        new Claim(ClaimTypes.Role, ((Roles)tokenResult.role).ToString()),
                        new Claim(ClaimTypes.Email, tokenResult.Email),
                        new Claim("UserId", tokenResult.UserId.ToString()),
                    }, "Custom Authentication"
                );
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }
    }
}
