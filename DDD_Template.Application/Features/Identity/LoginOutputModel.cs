namespace DDD_Template.Application.Features.Identity
{
    public class LoginOutputModel
    {
        public LoginOutputModel(string token) => Token = token;

        public string Token { get; set; }
    }
}
