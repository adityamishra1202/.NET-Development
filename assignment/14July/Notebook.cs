using System;

class Notebook : StationeryItem
{
    public int Pages;
    public string PaperType;

    public Notebook()
    {

    }

    public Notebook(int id, string name, string category, double price,
        int quantity, string brand, int pages, string paperType)
        : base(id, name, category, price, quantity, brand)
    {
        Pages = pages;
        PaperType = paperType;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Pages : " + Pages);
        Console.WriteLine("Paper Type : " + PaperType);
    }

    public override double CalculateDiscount(double price)
    {
        return price * 0.10;
    }
}