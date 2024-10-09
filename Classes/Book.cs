using System.Data.Common;

public class Book {

    // Denne variabelen sammen med konstruktøren, gjør at hvert Book-objekt får en unik id tilsvarende 
    // det forrige Book-objektets + 1.
    private static int _id = 0;

    public int Id {get; set;}
    public string Title {get; set;}
    public string? Author {get; set;}
    public int? Year {get; set;}

    public Book(string title, string author, int year) {
        Id = _id++;
        Title = title;
        Author = author;
        Year = year;
    }
}

public class Model {
    public List<Book> Books {get; set;}
    public Model() {
        Books = new List<Book> {
            new Book("Decline and Fall", "Evelyn Waugh", 1927),
            new Book("Philosophy and the Mirror of Nature", "Richard Rorty", 1979)
        };
    } 
}