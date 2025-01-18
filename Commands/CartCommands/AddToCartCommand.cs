public class AddToCartCommand : Command
{
    public AddToCartCommand(GetServices getServices)
        : base(
            "add",
            "Add",
            "Adds a product to your cart. <add [product-id] [quantity]>",
            false,
            getServices
        ) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
