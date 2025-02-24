using System;
using System.Collections.Generic;
using Spectre.Console;

public class Ebooks:Books{
    //properties of Ebooks
    public string TypeOfBook { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }

    public int SizeMb { get; set; }
    //Ebooks constructor
    public Ebooks(string typeofbook,string title, string author, string description, int sizeMb){
        TypeOfBook = typeofbook;
        Title = title;
        Author = author;
        Description = description;
        SizeMb = sizeMb;
    }
    public string DisplayUniqueInfo(){  
        return SizeMb.ToString();      
    }
}