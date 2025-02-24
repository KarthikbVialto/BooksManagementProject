using System;
using Spectre.Console;
public interface Books{
    string TypeOfBook{get;set;}
    string Title{get; set;}
    string Author{get; set;}
    string Description{get; set;}

    
    abstract string DisplayUniqueInfo();
     
    
}