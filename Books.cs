using System;
public interface Books{
    
    string Title{get; set;}
    string Author{get; set;}
    string Description{get; set;}

    abstract string[] DisplayInfo();
     
    
}