using System.Collections.Generic;
using System;
using Spectre.Console;
public class BooksManagement{
    public List<Books> books = new List<Books>();

    public  void AddBook(Books book){
        books.Add(book);
    }

    public void DisplayInfo(bool printedBook,bool ebook,bool allbooks){
        var table = new Table();
        table.AddColumn("Type");
        table.AddColumn("Title");
        table.AddColumn("Author");
        table.AddColumn("Desrciption");
        table.AddColumn("No of pages");
        table.AddColumn("Size in Mb");
        if(printedBook){
            foreach(Books book in books){
                string[] data;
                if(book is PrintedBooks printedBooks){
                    data = book.DisplayInfo();
                    table.AddRow(data[0],data[1],data[2],data[3],data[4],data[5]);
                    table.AddEmptyRow();
                }
            }
            AnsiConsole.Write(table);
            Console.ReadLine();
        }
        else if(ebook){
            foreach(Books book in books){
                string[] data;
                if(book is Ebooks ebooks){
                    data = book.DisplayInfo();
                    table.AddRow(data[0],data[1],data[2],data[3],data[4],data[5]);
                    table.AddEmptyRow();
                }
            }
            AnsiConsole.Write(table);
            Console.ReadLine();

        }
        else{
            foreach(Books book in books){
                string[] data;
                data =book.DisplayInfo();
                table.AddRow(data[0],data[1],data[2],data[3],data[4],data[5]);
                table.AddEmptyRow();
            }
            AnsiConsole.Write(table);
            Console.ReadLine();

        }
    }
}