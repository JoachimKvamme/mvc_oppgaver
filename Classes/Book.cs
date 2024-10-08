public class Book {
    public int Id {get; set;}
    public string Title {get; set;}
    public string? Author {get; set;}
    public int? Year {get; set;}

    public Book(int id, string title, string author, int year) {
        Id = id;
        Title = title;
        Author = author;
        Year = year;
    }
}

public class Model {
    public List<Book> Books {get; set;}
    public Model() {
        Books = new List<Book> {
            new Book(1, "Decline and Fall", "Evelyn Waugh", 1927),
            new Book(2, "Philosophy and the Mirror of Nature", "Richard Rorty", 1979)
        };
    } 
}