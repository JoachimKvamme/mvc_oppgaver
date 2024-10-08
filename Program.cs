using System.ComponentModel.DataAnnotations;

namespace mvc_oppgaver;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller(model, view);
        view.Display(model);
        //controller.UpdateTitle(1);
        view.Display(model);
        controller.Run();

        
    }
}
