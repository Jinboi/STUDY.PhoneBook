using PhoneBook;
using Spectre.Console;

var isAppRunning = true;
while (isAppRunning)
{
    var option = AnsiConsole.Prompt(
        new SelectionPrompt<MenuOptions>()
        .Title("What would you like to do?")
        .AddChoices(
            MenuOptions.AddProduct,
            MenuOptions.DeleteProduct,
            MenuOptions.UpdateProduct,
            MenuOptions.ViewAllProducts,
            MenuOptions.ViewProduct));

    switch (option)
    {
        case MenuOptions.AddProduct:
            ProductController.AddProduct();
            break;
        case MenuOptions.DeleteProduct:
            ProductController.DeleteProduct();
            break;

        case MenuOptions.UpdateProduct:
            ProductController.UpdateProduct();
            break;

        case MenuOptions.ViewAllProducts:
            ProductController.ViewAllProducts();
            break;

        case MenuOptions.ViewProduct:
            ProductController.ViewProduct();
            break;
    }
}

enum MenuOptions
{
    AddProduct,
    DeleteProduct,
    UpdateProduct,
    ViewAllProducts,
    ViewProduct,
    Quit
}