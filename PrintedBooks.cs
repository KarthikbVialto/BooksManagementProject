using System;
using System.Collections.Generic;
using Spectre.Console;

public class PrintedBooks:Books{
    //properties of printed books
    public string TypeOfBook { get; set; }
    public string Title{ get; set; }
    public string Author{ get; set; }

    public string Description{ get; set; }

    public int NoOfPages { get; set; }
    
    
    
    public PrintedBooks(string typeofbook,string title, string author, string description, int noOfPages){
        TypeOfBook = typeofbook;
        Title = title;
        Author = author;
        Description = description;
        NoOfPages = noOfPages;
    }
    public string DisplayUniqueInfo(){
        return NoOfPages.ToString();
    }


}