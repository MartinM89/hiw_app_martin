public class ExitCartCommand : Command
{
    public ExitCartCommand(GetServices getServices)
        : base("exit", "Exit", "Exists cart back to product menu.", false, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
