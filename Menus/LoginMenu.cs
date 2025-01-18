public class LoginMenu : Menu
{
    public LoginMenu(GetServices getServices)
        : base(getServices, "Login Menu:")
    {
        AddCommand(new RegisterUserCommand(getServices));
        AddCommand(new LoginUserCommand(getServices));
        AddCommand(new ExitCommand(getServices));
        AddCommand(new RegisterAdminCommand(getServices));
        AddCommand(new LoginAdminCommand(getServices));
        AddCommand(new HelpCommand(getServices));
    }
}
