public class ProductMenu : Menu
{
    public ProductMenu(GetServices getServices)
        : base(getServices, "Product Menu:")
    {
        AddCommand(new TableOfContentsCommand(getServices));
        AddCommand(new AddToCartCommand(getServices));
        AddCommand(new DisplayCartCommand(getServices));
        AddCommand(new ExitProductCommand(getServices));
        AddCommand(new HelpCommand(getServices));
    }

    public override void Display()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Product Menu!");
        Helper.PressKeyToContinue();
    }
}
