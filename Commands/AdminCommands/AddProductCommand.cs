public class AddProductCommand : Command
{
    public AddProductCommand(GetServices getServices)
        : base("1", "Add", "Adds a product to the catalogue.", true, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
