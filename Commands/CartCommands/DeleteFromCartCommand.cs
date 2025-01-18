public class DeleteFromCartCommand : Command
{
    public DeleteFromCartCommand(GetServices getServices)
        : base(
            "delete",
            "Delete",
            "Deletes a product from your cart. <delete [id]>",
            false,
            getServices
        ) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
