public class View {
    public void Display(Model model) {
        foreach (var book in model.Books)
        {
            Console.WriteLine(book.Title);
        }
    }
}