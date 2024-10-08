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


    public void DisplayBooks(Model model) {
        _view.Display(model);
    }
    public void Run() {
        Console.WriteLine("Which operation do you wish too perform on the list of books in model?");
    }
}