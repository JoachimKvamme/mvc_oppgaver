using System.ComponentModel.Design;

public class Controller {
    private Model _model;
    private View _view;


    public Controller(Model model, View view) {
        _model = model;
        _view = view;
    }

    // Update-metodene under tar book-id som parameter, og lar brukeren endre den valgte egenskapen.
    public void UpdateTitle(int id) {
        Console.WriteLine($"Please choose a new title for the book with the title {_model.Books[id].Title}:");
        string? newTitle = Console.ReadLine();
        _model.Books[id].Title = newTitle;
    }
     public void UpdateAuthor(int id) {
        Console.WriteLine($"Please choose a new author for the book with the title {_model.Books[id].Title}:");
        string? newAuthor = Console.ReadLine();
        _model.Books[id].Author = newAuthor;

    }
    public void UpdateYear(int id) {
        Console.WriteLine($"Please choose a new release year for the book with the title {_model.Books[id].Title}:");
        int newYear = int.Parse(Console.ReadLine());
        _model.Books[id].Year = newYear;

    }

    public void AddBook(Book book) {
        _model.Books.Add(book);
    }
    public void RemoveBook(int id) {
        _model.Books.RemoveAt(id);
    }
   


    public void DisplayBooks() {
        _view.Display(_model);
    }
    public void Run() {
        bool flag = true;
        while (flag) {
        Console.WriteLine("Which operation do you wish too perform on the list of books in model?");
        Console.WriteLine("You can choose to update a book based on the id, remove a book by id, or add a completely new book");
        Console.WriteLine("To update, type 'update', to remove type 'remove' og to add type 'add'. If you want to see the full list of books, type 'view'. To quit write 'quit' or 'q'.");

        string? userInput = Console.ReadLine();
        switch (userInput) {
            case "update":
            Console.WriteLine("Please select the id of the book you want to update");
            DisplayBooks();
            int bookId = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have choosen to update the book {_model.Books[bookId-1].Title} with the Id {bookId}, released {_model.Books[bookId-1].Year} and written by {_model.Books[bookId-1].Author}");
            Console.WriteLine($"Do you wish to update the title, the year or the author? Please type 'title', 'year' or 'author'");
            string updateChoice = Console.ReadLine();
            switch (updateChoice) {
                case "title":
                UpdateTitle(bookId);
                DisplayBooks();
                break;
                case "year":
                UpdateYear(bookId);
                break;
                case "author":
                UpdateAuthor(bookId);
                break;
                default:
                break;
            }
            
            break;
            case "remove":
            DisplayBooks();
            Console.WriteLine("Please enter the Id of the book you want to remove.");
            int removeId = int.Parse(Console.ReadLine());
            RemoveBook(removeId);
            DisplayBooks();
            break;
            case "add":
            DisplayBooks();
            Console.WriteLine("What is the title of the book you wish to add?");
            string title = Console.ReadLine();
            Console.WriteLine("What is the author of the book you wish to add?");
            string author = Console.ReadLine();
            Console.WriteLine("What year was the book released?");
            int year = int.Parse(Console.ReadLine());
            Book newBook = new Book(title,author,year);
            _model.Books.Add(newBook);
            DisplayBooks();
            break;
            case "view":
            DisplayBooks();
            break;
            case "quit":
            case "q":
            flag = false;
            break;
            default:
            Console.WriteLine("You must choose to update, remove og add, with the correct prompts.");
            break;
        }
        }

    }
}