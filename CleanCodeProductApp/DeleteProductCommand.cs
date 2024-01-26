namespace CleanCodeOdev;

public class DeleteProductCommand(IProductService productService, IInputService inputService) : ICommand
{
    public void Execute()
    {
        var id = inputService.GetInput("Silinecek Ürünün ID'si: ");
        productService.DeleteProduct(id);
    }
}