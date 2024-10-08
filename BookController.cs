using System.ComponentModel.Design;

public class Controller {
    private Model _model;
    private View _view;


    public Controller(Model model, View view) {
        _model = model;
        _view = view;
    }
    public void UpdateTitle(int id) {
        Console.WriteLine($"Please choose a new title for the book with the title {_model.Books[id].Title}:");
        string? newTitle = Console.ReadLine();
        _model.Books[id].Title = newTitle;
    }

    public void AddBook(Book book) {
        _model.Books.Add(book);
    }
    public void RemoveBook(int id) {
        _model.Books.RemoveAt(id);
    }
    public void UpdateAuthor(int id) {

    }
    public void UpdateYear(int id) {

    }


    public void DisplayBooks() {
        _view.Display(_model);
    }
    public void Run() {
        Console.WriteLine("Which operation do you wish too perform on the list of books in model?");
        Console.WriteLine("You can choose to update a book based on the id, remove a book by id, or add a completely new book");
        Console.WriteLine("To update, type 'update', to remove type 'remove' og to add type 'add'");

        string? userInput = Console.ReadLine();
        switch (userInput) {
            case "update":
            Console.WriteLine("Please select the id of the book you want to update");
            DisplayBooks();
            int bookId = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have choosen to update the book {_model.Books[bookId-1].Title} with the Id {bookId}, released {_model.Books[bookId-1].Year} and written by {_model.Books[bookId-1].Author}");
            Console.WriteLine($"Do you wish to update the title, the year or the author? Please type 'title', 'year' or 'author'");
            string updateChoice = Console.ReadLine();
            
            
            break;
            case "remove":
            break;
            case "add":
            break;
            default:
            Console.WriteLine("You must choose to update, remove og add, with the correct prompts.");
            break;
        }

    }
}