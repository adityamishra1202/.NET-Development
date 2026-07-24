using System;

class OOP
{
    static void Main()
    {
        Employee e = new Employee();

        e.EmpName = "Mamta";
        e.Salary = 1000;

        Console.WriteLine(e.EmpName + " " + e.Salary);

    // complile time polymorphism= same  methods ,diffrent paramenters.

        CompiletimePoly c = new CompiletimePoly();
        c.Search(101);
        c.Search(789654123L);
        c.Search("Mamta", "Boga");


// run time poly morphism =run time poly never konow which payment it is using methods to do payment.it simply calls the actual implementation.

        RuntimePoly r = new RuntimePoly();
        r.Checkout(new UpiPayment(), 500);
        r.Checkout(new CreditPayment(), 55000);
        r.Checkout(new NetBanking(), 25000);


        FileStorage s = new Abstracteg();
        s.Upload("CV.pdf");
        s.ValidateFile();
    
    }
    
}