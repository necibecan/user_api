namespace CleanCodeOdev;

public class ListProductsCommand(IProductService productService) : ICommand
{
    public void Execute()
    {
        productService.ListProducts();
    }
}