public abstract class Command
{
    public string InputKey { get; init; }
    public string CommandName { get; init; }
    public string Description { get; init; }
    public bool IsVisibleCommand { get; init; }
    protected GetServices GetServices { get; init; }

    public Command(
        string inputKey,
        string commandName,
        string description,
        bool isVisibleCommand,
        GetServices getServices
    )
    {
        InputKey = inputKey;
        CommandName = commandName;
        Description = description;
        IsVisibleCommand = isVisibleCommand;
        GetServices = getServices;
    }

    public abstract void Execute(string[] input);
}
