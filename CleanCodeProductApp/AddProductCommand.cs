namespace CleanCodeOdev;

public class AddProductCommand(IProductService productService, IInputService inputService) : ICommand
{
    public void Execute()
    {
        var id = inputService.GetInput("Ürün ID: ");
        var name = inputService.GetInput("Ürün İsmi: ");
        var categoryNumber = inputService.GetInput("Kategori Numarası: ");
        var product = new Product { Id = id, Name = name, CategoryNumber = categoryNumber };
        productService.AddProduct(product);
    }
}