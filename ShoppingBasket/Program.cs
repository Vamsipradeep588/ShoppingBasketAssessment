using ShoppingBasket;

Console.WriteLine("Shopping Basket Calculator");
Console.WriteLine("Enter items separated by commas: Apple, Banana, Melon, Lime");
Console.Write("Basket: ");

string? input = Console.ReadLine();

try
{
    var items = string.IsNullOrWhiteSpace(input)
        ? Array.Empty<string>()
        : input.Split(',', StringSplitOptions.TrimEntries);

    int totalPence = new ShoppingBasketCalculator().CalculateTotalPence(items);
    Console.WriteLine($"Total: {totalPence}p (£{totalPence / 100.0:F2})");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Input error: {ex.Message}");
}
