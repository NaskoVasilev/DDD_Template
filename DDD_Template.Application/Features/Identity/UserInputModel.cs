namespace DDD_Template.Application.Features.Identity
{
    public class UserInputModel
    {
        public UserInputModel(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
