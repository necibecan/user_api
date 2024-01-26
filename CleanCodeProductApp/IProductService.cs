namespace CleanCodeOdev;

public interface IProductService
{
    void AddProduct(Product product);
    void ListProducts();
    void DeleteProduct(string id);
    void UpdateProduct(string id, Product newProductDetails);
}