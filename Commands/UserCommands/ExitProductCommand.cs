public class ExitProductCommand : Command
{
    public ExitProductCommand(GetServices getServices)
        : base("exit", "Exit", "Exit product menu back to login menu.", false, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
