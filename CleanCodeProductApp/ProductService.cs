namespace CleanCodeOdev;

public class ProductService : IProductService
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        if (_products.Any(p => p.Id == product.Id))
        {
            Console.WriteLine("Bu ID'ye sahip bir ürün zaten var.");
            return;
        }

        _products.Add(product);
    }

    public void ListProducts()
    {
        if (_products.Count == 0)
        {
            Console.WriteLine("Listelenecek ürün yok.");
            return;
        }

        foreach (var product in _products)
        {
            Console.WriteLine($"ID: {product.Id}, İsim: {product.Name}, Kategori: {product.CategoryNumber}");
        }
    }

    public void DeleteProduct(string id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            Console.WriteLine("Ürün bulunamadı.");
            return;
        }

        _products.Remove(product);
        Console.WriteLine("Ürün silindi.");
    }

    public void UpdateProduct(string id, Product newProductDetails)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            Console.WriteLine("Ürün bulunamadı.");
            return;
        }

        product.Name = newProductDetails.Name;
        product.CategoryNumber = newProductDetails.CategoryNumber;
        Console.WriteLine("Ürün güncellendi.");
    }
}