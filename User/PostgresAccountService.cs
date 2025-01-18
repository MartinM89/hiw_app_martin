public class PostgresUserService : IUserService
{
    public User user
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public bool CheckUsernameAlreadyUsed(string username)
    {
        throw new NotImplementedException();
    }

    public User GetAccountObject(string username)
    {
        throw new NotImplementedException();
    }

    public void Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public void Register(User user)
    {
        try
        {
            using AppContext context = new AppContext();

            context.Users?.Add(user);
            context.SaveChanges();
        }
        catch (Exception)
        {
            throw new Exception("Error: Could not register user.");
        }
    }
}
