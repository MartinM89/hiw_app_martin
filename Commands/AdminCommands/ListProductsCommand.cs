public class ListProductsCommand : Command
{
    public ListProductsCommand(GetServices getServices)
        : base("3", "List", "Lists all products in the catalogue.", true, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
