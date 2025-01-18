public class DisplayCartCommand : Command
{
    public DisplayCartCommand(GetServices getServices)
        : base("cart", "Cart", "Displays your cart.", false, getServices) { }

    public override void Execute(string[] input)
    {
        throw new NotImplementedException();
    }
}
