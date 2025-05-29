// Тестування функціональності
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створення товару
        Money price = new Money(120, 50);
        Product product = new Product("Молоко", "л", price);

        // Вивід ціни продукту
        Console.WriteLine("Початкова ціна товару:");
        product.Display();

        // Зменшення ціни товару
        product.ReducePrice(25);
        Console.WriteLine("Ціна після знижки:");
        product.Display();

        // Створення звітності та додавання товару на склад
        Reporting reporting = new Reporting();
        reporting.Supply(product, 100, DateTime.Now);

        // Звіт по складу після надходження
        reporting.InventoryReport();

        // Відвантаження частини товару
        reporting.Ship("Молоко", 10);

        // Остаточний звіт по складу
        reporting.InventoryReport();

        // Затримка завершення
        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}