public class LoginUserCommand : Command
{
    public LoginUserCommand(GetServices getServices)
        : base("2", "Login", "Login registered user.", true, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
