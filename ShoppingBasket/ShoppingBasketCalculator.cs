namespace ShoppingBasket;

public sealed class ShoppingBasketCalculator
{
    private const int ApplePrice = 35;
    private const int BananaPrice = 20;
    private const int MelonPrice = 50;
    private const int LimePrice = 15;

    private static readonly string[] ValidItems = { "Apple", "Banana", "Melon", "Lime" };

    public int CalculateTotalPence(IEnumerable<string>? items)
    {
        ArgumentNullException.ThrowIfNull(items);

        var quantities = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (var item in items)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Basket items cannot be blank.", nameof(items));

            string name = item.Trim();

            if (!ValidItems.Contains(name, StringComparer.OrdinalIgnoreCase))
                throw new ArgumentException($"Unknown item: '{item}'.", nameof(items));

            quantities[name] = quantities.GetValueOrDefault(name) + 1;
        }

        int apples = quantities.GetValueOrDefault("Apple") * ApplePrice;
        int bananas = quantities.GetValueOrDefault("Banana") * BananaPrice;

        int melonCount = quantities.GetValueOrDefault("Melon");
        int melons = ((melonCount + 1) / 2) * MelonPrice;

        int limeCount = quantities.GetValueOrDefault("Lime");
        int limes = ((limeCount / 3) * 2 + limeCount % 3) * LimePrice;

        return apples + bananas + melons + limes;
    }
}
