public class LoginAdminCommand : Command
{
    public LoginAdminCommand(GetServices getServices)
        : base("8", "Login-admin", "Hidden login command for admins.", false, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
