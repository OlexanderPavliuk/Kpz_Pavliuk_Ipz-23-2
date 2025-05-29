class Reporting
{
    private List<WarehouseItem> inventory = new List<WarehouseItem>();

    public void Supply(Product product, int quantity, DateTime date)
    {
        inventory.Add(new WarehouseItem(product, quantity, date));
        Console.WriteLine("Надходження зареєстровано.");
    }

    public void Ship(string productName, int quantity)
    {
        foreach (var item in inventory)
        {
            if (item.Product.Name == productName && item.Quantity >= quantity)
            {
                item.Quantity -= quantity;
                Console.WriteLine($"Відвантажено: {quantity} одиниць продукту {productName}");
                return;
            }
        }
        Console.WriteLine("Недостатньо товару або не знайдено.");
    }

    public void InventoryReport()
    {
        Console.WriteLine("Звіт по залишках на складі:");
        foreach (var item in inventory)
        {
            item.Display();
        }
    }
}