class Vehicle
{
 public int Vid;
 public string Vname;
 public string Vtype;
 public string Vbrand;
 public int Vprice;
 public string Vyear;

 public Vehicle(int i,string n,string t,string b,int p,string y)
    {
        Vid=i;
        Vname=n;
        Vtype=t;
        Vbrand=b;
        Vprice=p;
        Vyear=y;
}   

public void display()
    {
        Console.WriteLine(Vid+"    "+Vname+"    "+Vbrand+"    "+Vtype+"    "+Vprice);
    }







}