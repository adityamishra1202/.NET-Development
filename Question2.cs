using System.Collections.Generic;
using System.IO.Compression;

class Question2
{
    int count=0;
   public void library(){
List<String> books=new List<String>();
books.Add("Panchtantra");
books.Add("Sherlock Homes");
books.Add("Bhagwat Gita");
foreach(String b in books)
        {
            Console.WriteLine(b);
        }
         Console.WriteLine("\n");
books.Add("Upnishads");
books.Remove("Panchtantra");
foreach(string b in books)
        {
         count+=1;
         Console.WriteLine(b)   ;
        }

Console.WriteLine("The number of books in library are:"+count);

   } 

}