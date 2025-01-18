public class UpdateProductCommand : Command
{
    public UpdateProductCommand(GetServices getServices)
        : base("4", "Update", "Updates a product from the catalogue.", true, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
