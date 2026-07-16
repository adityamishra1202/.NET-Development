using System;
using System.Collections.Generic;

class StoreManager : IBill
{
    List<StationeryItem> items = new List<StationeryItem>();

    double billPrice = 0;
    int billQty = 0;
    double billDiscount = 0;
    double billGST = 0;
    double billTotal = 0;
    string billItem = "";

    public void AddItem(StationeryItem item)
    {
        foreach (StationeryItem s in items)
        {
            if (s.ItemId == item.ItemId)
            {
                throw new DuplicateItemException();
            }
        }

        items.Add(item);
        Console.WriteLine("Item Added Successfully");
    }

    public void DisplayAllItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("No Items Available");
            return;
        }

        foreach (StationeryItem s in items)
        {
            Console.WriteLine("--------------------------");
            s.DisplayDetails();
        }
    }

    public StationeryItem SearchItem(int id)
    {
        foreach (StationeryItem s in items)
        {
            if (s.ItemId == id)
            {
                return s;
            }
        }

        throw new ItemNotFoundException();
    }

    public void UpdateItem(int id)
    {
        StationeryItem s = SearchItem(id);

        Console.WriteLine("Enter New Price");
        s.Price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter New Quantity");
        s.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter New Brand");
        s.Brand = Console.ReadLine();

        Console.WriteLine("Item Updated Successfully");
    }

    public void DeleteItem(int id)
    {
        StationeryItem s = SearchItem(id);

        Console.WriteLine("Delete Item ? (Y/N)");
        char ch = Convert.ToChar(Console.ReadLine());

        if (ch == 'Y' || ch == 'y')
        {
            items.Remove(s);
            Console.WriteLine("Item Deleted");
        }
        else
        {
            Console.WriteLine("Delete Cancelled");
        }
    }

    public void PurchaseItem(int id, int qty)
    {
        StationeryItem s = SearchItem(id);

        if (qty > s.Quantity)
        {
            throw new InsufficientStockException();
        }

        s.Quantity = s.Quantity - qty;

        billItem = s.ItemName;
        billPrice = s.Price;
        billQty = qty;
        billDiscount = s.CalculateDiscount(s.Price) * qty;

        double amount = s.Price * qty;

        billGST = (amount - billDiscount) * 0.18;
        billTotal = amount - billDiscount + billGST;

        GenerateBill();
    }

    public void ViewLowStockItems()
    {
        bool found = false;

        foreach (StationeryItem s in items)
        {
            if (s.Quantity < 5)
            {
                found = true;
                s.DisplayDetails();
                Console.WriteLine("---------------------");
            }
        }

        if (!found)
        {
            Console.WriteLine("No Low Stock Items");
        }
    }

    public void SortByPrice()
    {
        items.Sort((a, b) => a.Price.CompareTo(b.Price));

        Console.WriteLine("Sorted By Price");
        DisplayAllItems();
    }

    public void SortByName()
    {
        items.Sort((a, b) => a.ItemName.CompareTo(b.ItemName));

        Console.WriteLine("Sorted By Name");
        DisplayAllItems();
    }

    public void SortByQuantity()
    {
        items.Sort((a, b) => a.Quantity.CompareTo(b.Quantity));

        Console.WriteLine("Sorted By Quantity");
        DisplayAllItems();
    }

    public void GenerateBill()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Item      : " + billItem);
        Console.WriteLine("Price     : " + billPrice);
        Console.WriteLine("Quantity  : " + billQty);
        Console.WriteLine("Discount  : " + billDiscount);
        Console.WriteLine("GST       : " + billGST);
        Console.WriteLine("Total     : " + billTotal);
        Console.WriteLine("--------------------------------");
    }
}