public class AdminMenu : Menu
{
    public AdminMenu(GetServices getServices)
        : base(getServices, "Admin Menu:")
    {
        AddCommand(new AddProductCommand(getServices));
        AddCommand(new DeleteProductCommand(getServices));
        AddCommand(new ListProductsCommand(getServices));
        AddCommand(new UpdateProductCommand(getServices));
        AddCommand(new LogoutAdminCommand(getServices));
        AddCommand(new HelpCommand(getServices));
    }
}
