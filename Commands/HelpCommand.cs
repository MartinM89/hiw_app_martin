public class HelpCommand : Command
{
    public HelpCommand(GetServices getServices)
        : base("help", "Help", "Shows menu relevant help command.", false, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
