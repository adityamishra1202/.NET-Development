using System;

class Pen : StationeryItem
{
    public string InkColor;
    public string PenType;

    public Pen()
    {

    }

    public Pen(int id, string name, string category, double price,
        int quantity, string brand, string inkColor, string penType)
        : base(id, name, category, price, quantity, brand)
    {
        InkColor = inkColor;
        PenType = penType;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Ink Color : " + InkColor);
        Console.WriteLine("Pen Type : " + PenType);
    }

    public override double CalculateDiscount(double price)
    {
        return price * 0.05;
    }
}