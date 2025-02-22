using System;
using System.Collections.Generic;

public class Ebooks:Books{
    
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }

    public int SizeMb { get; set; }

    public Ebooks(string title, string author, string description, int sizeMb){
        Title = title;
        Author = author;
        Description = description;
        SizeMb = sizeMb;
    }
    public string[] DisplayInfo(){
        string[] data = {"Ebook",Title,Author,Description,"NA",SizeMb.ToString()};
        return data;
    }
}