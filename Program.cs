using System;
using System.Collections.Generic;
using Spectre.Console;


public class Program{

    public static void RenderLayout(){
        //top panel for book management menu
         var topPanel = new Panel(
            new Markup("[bold yellow]Book Management Menu[/]\n" +
                       "[blue]1. Add a Book[/]\n" +
                       "[blue]2. List PrintedBooks[/]\n" +
                       "[blue]3. List EBooks[/]\n" +
                       "[blue]4. List All Books[/]\n" +
                       "[blue]5. Exit[/]")
        ).Border(BoxBorder.Rounded).Expand();

        // Bottom panel for user input
        var bottomPanel = new Panel(
            new Markup("[bold green]User Input & Books Table[/]\n" +
                       "Follow Instructions to interact with system.")
        ).Border(BoxBorder.Rounded).Expand();

        
        var grid = new Grid();
        grid.AddColumn(new GridColumn().NoWrap());
        grid.AddRow(topPanel);
        grid.AddRow(bottomPanel);

       
        AnsiConsole.Write(grid);
    }
    public static void Main(string[] args){

        BooksManagement booksManagement = new BooksManagement();
        bool IsExit = true;
        while(IsExit){
            try{
                AnsiConsole.Clear(); 
                RenderLayout();
                bool printedBook = false;
                bool ebook = false;
                bool allbooks = false;
                int input = int.Parse(AnsiConsole.Ask<string>("Please Select an option from above options:"));
                if(input<1|| input>5)throw new InvalidDataException();

                switch(input){

                    #region Add book case
                        case 1:
                        AnsiConsole.Clear();
                        var table = new Table();
                        table.AddColumn("Please select an option");
                        table.AddRow("1. PrintedBooks");
                        table.AddRow("2. Ebooks");
                        AnsiConsole.Write(table);
                        int BookType = int.Parse(AnsiConsole.Ask<string>("Types of Books:"));
                        if(BookType<1|| BookType>2)throw new InvalidDataException();
                       
                        string Title = AnsiConsole.Ask<string>("Enter Title of Book:");

                        string Author = AnsiConsole.Ask<string>("Enter Author of Book:");
                        
                        string Description = AnsiConsole.Ask<string>("Enter Description of Book:");
                    
                        if (BookType == 1){
                            int NoOfPages = int.Parse(AnsiConsole.Ask<string>("Enter No of pages in Book:"));
                            booksManagement.AddBook(new PrintedBooks("Printed Book",Title,Author,Description,NoOfPages));
                        }
                        else{
                            int  sizeMb = int.Parse(AnsiConsole.Ask<string>("Enter size of  Book in Mb:"));
                            booksManagement.AddBook(new Ebooks("Ebook",Title,Author,Description,sizeMb));
                        }
                        break;
                    #endregion

                    #region PrintedBook display
                        case 2:
                        printedBook = true;
                        booksManagement.DisplayInfo(printedBook,ebook,allbooks);
                        break;
                    #endregion

                    #region Ebooks display
                        case 3:
                        ebook = true;
                        booksManagement.DisplayInfo(printedBook,ebook,allbooks);
                        break;
                    #endregion

                    #region All books display
                    case 4:
                        allbooks = true;
                        booksManagement.DisplayInfo(printedBook,ebook,allbooks);
                        break;
                    #endregion

                    #region Exit
                    case 5: IsExit = false;
                            break;
                    #endregion
                }
            }
            catch(InvalidDataException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
