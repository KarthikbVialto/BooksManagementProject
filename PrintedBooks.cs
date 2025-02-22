using System;
using System.Collections.Generic;

public class PrintedBooks:Books{
    
    public string Title{ get; set; }
    public string Author{ get; set; }

    public string Description{ get; set; }

    int NoOfPages { get; set; }
    
    public PrintedBooks(string title, string author, string description, int noOfPages){
        Title = title;
        Author = author;
        Description = description;
        NoOfPages = noOfPages;
    }
    public string[] DisplayInfo(){
        string[] data = {"Printed book",Title,Author,Description,NoOfPages.ToString(),"NA"};
        return data;
    }
}