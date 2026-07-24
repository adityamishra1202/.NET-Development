using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
public class FileHandling
{
    
public void Filo()
    {
        
File.WriteAllText("emp.txt","Name=Aditya");
string data=File.ReadAllText("emp.txt");
Console.WriteLine(data);


    }



}