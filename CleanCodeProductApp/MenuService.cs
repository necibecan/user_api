namespace CleanCodeOdev;

public class MenuService(IProductService productService, IInputService inputService)
{
    private readonly IProductService _productService = productService;

    private readonly Dictionary<MenuOption, ICommand> _commands = new()
    {
        { MenuOption.ListProducts, new ListProductsCommand(productService) },
        { MenuOption.AddProduct, new AddProductCommand(productService, inputService) },
        { MenuOption.DeleteProduct, new DeleteProductCommand(productService, inputService) },
        { MenuOption.UpdateProduct, new UpdateProductCommand(productService, inputService) },
        { MenuOption.Exit, new ExitCommand() }
    };

    public static void DisplayMenu()
    {
        Console.WriteLine("1. Ürün Listele");
        Console.WriteLine("2. Ürün Ekle");
        Console.WriteLine("3. Ürün Sil");
        Console.WriteLine("4. Ürün Güncelle");
        Console.WriteLine("5. Çıkış");
    }

    public MenuOption GetMenuChoice()
    {
        var choice = inputService.GetInput("Seçiminiz: ");
        return choice switch
        {
            "1" => MenuOption.ListProducts,
            "2" => MenuOption.AddProduct,
            "3" => MenuOption.DeleteProduct,
            "4" => MenuOption.UpdateProduct,
            "5" => MenuOption.Exit,
            _ => MenuOption.Exit,
        };
    }

    public void ExecuteCommand(MenuOption option)
    {
        if (_commands.TryGetValue(option, out var command))
        {
            command.Execute();
        }
        else
        {
            Console.WriteLine("Geçersiz seçim.");
        }
    }
}