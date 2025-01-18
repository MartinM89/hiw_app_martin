public class RegisterUserCommand : Command
{
    public RegisterUserCommand(GetServices getServices)
        : base("1", "Register", "Registers a new user.", true, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
