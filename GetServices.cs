public class GetServices
{
    public IUserService AccountService { get; private set; }
    public IMenuService MenuService { get; private set; }
    public IProductService ProductService { get; private set; }
    public ICartService CartService { get; private set; }

    public GetServices()
    {
        MenuService = new SimpleMenuService();
        AccountService = new PostgresUserService();
        ProductService = new PostgresProductService();
        CartService = new PostgresCartService();
    }
}
