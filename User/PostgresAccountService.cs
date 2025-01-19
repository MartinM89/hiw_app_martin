public class PostgresUserService : IUserService
{
    public User? User { get; set; }

    public bool CheckIfAnyAccountExists()
    {
        try
        {
            using AppContext context = new AppContext();

            return context.Users.Any();
        }
        catch (Exception)
        {
            throw new Exception("Error: Could not check if any account exists.");
        }
    }

    public bool CheckUsernameAlreadyUsed(string username)
    {
        try
        {
            using AppContext context = new AppContext();

            User? account = context.Users.FirstOrDefault(a => a.Email == username);

            return account != null;
        }
        catch (Exception)
        {
            throw new Exception("Error: Could not check if username is already used.");
        }
    }

    public User GetAccountObject(string username)
    {
        throw new NotImplementedException();
    }

    public void Login(string username, string password)
    {
        try
        {
            using var context = new AppContext();

            User? account = context
                .Users.ToList()
                .FirstOrDefault(u =>
                    u.Email == username
                    && BCrypt.Net.BCrypt.EnhancedVerify(password, u.PasswordHash)
                );

            if (account == null)
            {
                throw new Exception("Error: Invalid username or password.");
            }

            User = account;
        }
        catch (Exception)
        {
            throw new Exception("Error: Could not login.");
        }
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
