public interface IProductService
{
    void AddProduct(Product product);
    List<Product> GetProducts();
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
}
