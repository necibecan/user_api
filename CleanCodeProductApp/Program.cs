// See https://aka.ms/new-console-template for more information

using CleanCodeOdev;

class Program
{ 
    static void Main(string[] args)
    {
        IProductService productService = new ProductService();
        IInputService inputService = new InputService();
        var menuService = new MenuService(productService, inputService);

        while (true)
        {
            MenuService.DisplayMenu();
            var choice = menuService.GetMenuChoice();
            menuService.ExecuteCommand(choice);
        }
    }
}