public interface ICartService
{
    Cart cart { get; set; }
    void AddProduct(Product product);
    void RemoveProduct(Product product);
    void UpdateProduct(Product product);
    List<Product> GetProducts();
    void ClearCart();
    Cart GetCart();
}
