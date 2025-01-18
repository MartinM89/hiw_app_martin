public interface IUserService
{
    User user { get; set; }
    void Register(User user);
    void Login(string username, string password);
    User GetAccountObject(string username);
    bool CheckUsernameAlreadyUsed(string username);
}
