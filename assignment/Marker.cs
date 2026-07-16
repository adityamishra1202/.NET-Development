using System;

class Marker : StationeryItem
{
    public bool Permanent;

    public Marker()
    {

    }

    public Marker(int id, string name, string category, double price,
        int quantity, string brand, bool permanent)
        : base(id, name, category, price, quantity, brand)
    {
        Permanent = permanent;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Permanent : " + Permanent);
    }

    public override double CalculateDiscount(double price)
    {
        return price * 0.08;
    }
}