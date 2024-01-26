namespace CleanCodeOdev;

public class UpdateProductCommand(IProductService productService, IInputService inputService) : ICommand
{
    public void Execute()
    {
        var id = inputService.GetInput("Güncellenecek Ürünün ID'si: ");
        var name = inputService.GetInput("Yeni Ürün İsmi: ");
        var categoryNumber = inputService.GetInput("Yeni Kategori Numarası: ");
        var product = new Product { Id = id, Name = name, CategoryNumber = categoryNumber };
        productService.UpdateProduct(id, product);
    }
}