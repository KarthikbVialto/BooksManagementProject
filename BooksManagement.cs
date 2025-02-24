using System.Collections.Generic;
using System;
using Spectre.Console;
public class BooksManagement{
    public List<Books> books = new List<Books>();

    public  void AddBook(Books book){
        books.Add(book);
    }

    public void DisplayInfo(bool printedBook,bool ebook,bool allbooks){
        #region table definition
        var table = new Table();
        table.AddColumn("Type");
        table.AddColumn("Title");
        table.AddColumn("Author");
        table.AddColumn("Desrciption");
        table.AddColumn("No of pages");
        table.AddColumn("Size in Mb");
        #endregion
        
        if(printedBook){
            foreach(Books book in books){
                
                if(book is PrintedBooks printedBooks){
                    string noOfPages = book.DisplayUniqueInfo();
                    table.AddRow(
                        book.TypeOfBook,
                        book.Title,
                        book.Author,
                        book.Description,
                        noOfPages,
                        "NA"
                    );
                }
            }
            AnsiConsole.Write(table);
            //press enter to clear console and select next option
            Console.WriteLine("Press enter to clear console and continue interaction!");
            Console.ReadLine();
        }
        else if(ebook){
            foreach(Books book in books){
                
                if(book is Ebooks ebooks){
                    string sizemb = book.DisplayUniqueInfo();
                    table.AddRow(
                        book.TypeOfBook,
                        book.Title,
                        book.Author,
                        book.Description,
                        "NA",//table field no of pages not applicable to ebook
                        sizemb
                    );
                }
            }
            AnsiConsole.Write(table);
            //press enter to clear console and select next option
            Console.WriteLine("Press enter to clear console and continue interaction!");
            Console.ReadLine();

        }
        else{
            foreach(Books book in books){
                string BookUniqueData;
                if (book is Ebooks ebooks){
                    BookUniqueData = book.DisplayUniqueInfo();
                    table.AddRow(
                    book.TypeOfBook,
                    book.Title,
                    book.Author,
                    book.Description,
                    "NA",
                    BookUniqueData
                    );
                    table.AddEmptyRow();

                }
                else{
                    BookUniqueData = book.DisplayUniqueInfo();
                    table.AddRow(
                    book.TypeOfBook,
                    book.Title,
                    book.Author,
                    book.Description,
                    BookUniqueData,
                    "NA"
                );
                table.AddEmptyRow();
                }
                
            }
            AnsiConsole.Write(table);
            //press enter to clear console and select next option
            Console.WriteLine("Press enter to clear console and continue interaction!");
            Console.ReadLine();

        }
    }
}