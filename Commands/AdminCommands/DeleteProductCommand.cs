public class DeleteProductCommand : Command
{
    public DeleteProductCommand(GetServices getServices)
        : base("2", "Delete product", "Deletes a product from the catalogue,", true, getServices)
    { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
