public class UpdateCartCommand : Command
{
    public UpdateCartCommand(GetServices getServices)
        : base(
            "update",
            "Update",
            "Update a product in your cart. <update [id] [quantity]>",
            false,
            getServices
        ) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
