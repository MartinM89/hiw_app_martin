public abstract class Menu
{
    private List<Command> commands { get; set; } = new List<Command>();
    private GetServices GetServices { get; set; }
    private string Title { get; set; }

    public Menu(GetServices getServices, string title)
    {
        Title = title;
        GetServices = getServices;
    }

    public void AddCommand(Command command)
    {
        commands.Add(command);
    }

    public void RunCommand(string input)
    {
        string[] inputArray = input.Split(' ');
        foreach (Command c in commands)
        {
            if (input.Equals(c.InputKey))
            {
                c.Execute(inputArray);
                return;
            }
        }
    }

    public virtual void Display()
    {
        Console.Clear();

        Console.WriteLine(Title + "\n");

        foreach (Command command in commands)
        {
            if (command.IsVisibleCommand.Equals(true))
            {
                Console.WriteLine($"    {command.InputKey}. {command.CommandName}");
            }
        }
    }
}
