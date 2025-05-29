class WarehouseItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public DateTime LastSupplyDate { get; set; }

    public WarehouseItem(Product product, int quantity, DateTime date)
    {
        Product = product;
        Quantity = quantity;
        LastSupplyDate = date;
    }

    public void Display()
    {
        Product.Display();
        Console.WriteLine($" Кількість: {Quantity}, Дата надходження: {LastSupplyDate.ToShortDateString()}");
    }
}