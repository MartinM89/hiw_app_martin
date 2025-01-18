public class ExitCommand : Command
{
    public ExitCommand(GetServices getServices)
        : base("3", "Exit", "Exit the application", true, getServices) { }

    public override void Execute(string[] input)
    {
        Environment.Exit(0);
    }
}
