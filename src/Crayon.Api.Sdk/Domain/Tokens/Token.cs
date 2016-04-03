namespace Crayon.Api.Sdk.Domain.Tokens
{
    public class Token
    {
        public string AccessToken { get; set; }

        public string IdentityToken { get; set; }

        public string Error { get; set; }

        public long ExpiresIn { get; set; }

        public string TokenType { get; set; }

        public string RefreshToken { get; set; }
    }
}