public class View {
    public void Display(Model model) {
        foreach (var book in model.Books)
        {
            Console.WriteLine($"Id: {book.Id} Title: {book.Title} Year: {book.Year}");
        }
    }
}