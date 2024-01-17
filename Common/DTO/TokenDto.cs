namespace Common.DTO
{
    public class TokenDto
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public bool? IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? RefreshTokenExpirationDate { get; set; }
    }
}
