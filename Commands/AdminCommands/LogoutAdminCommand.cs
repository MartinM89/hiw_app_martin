public class LogoutAdminCommand : Command
{
    public LogoutAdminCommand(GetServices getServices)
        : base("5", "Logout admin", "Log out command for admins.", true, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
