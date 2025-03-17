namespace SMS.Shared.JWTToken
{
    public interface ITokenService
    {
        Task StoreTokensAsync(string accessToken, string refreshToken);
        Task RemoveTokensAsync();
        Task<string> GetUserToken();
        Task<JwtDTO?> GetClaimFromToken();
        Task<bool> IsTokenValid();
    }
}
