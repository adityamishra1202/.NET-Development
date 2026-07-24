using System;

class StationeryItem : Product
{
    private int itemId;
    private string itemName;
    private string category;
    private double price;
    private int quantity;
    private string brand;

    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
                throw new InvalidPriceException();

            price = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value <= 0)
                throw new InvalidQuantityException();

            quantity = value;
        }
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public StationeryItem()
    {

    }

    public StationeryItem(int id, string name, string cat, double pr, int qty, string br)
    {
        ItemId = id;
        ItemName = name;
        Category = cat;
        Price = pr;
        Quantity = qty;
        Brand = br;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Item Id : " + ItemId);
        Console.WriteLine("Name : " + ItemName);
        Console.WriteLine("Category : " + Category);
        Console.WriteLine("Brand : " + Brand);
        Console.WriteLine("Price : " + Price);
        Console.WriteLine("Quantity : " + Quantity);
    }

    public void UpdateQuantity(int qty)
    {
        Quantity = qty;
    }

    public override double CalculateDiscount(double price)
    {
        return price;
    }
}