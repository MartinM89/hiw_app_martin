public interface IUserService
{
    User? User { get; set; }
    bool CheckIfAnyAccountExists();
    void Register(User user);
    void Login(string username, string password);
    User GetAccountObject(string username);
    bool CheckUsernameAlreadyUsed(string username);
}
