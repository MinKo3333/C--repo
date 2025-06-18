namespace Butikkoversikt;

class Program
{
    static void Main(string[] args)
    {
        UI ui = new UI();
        
        ui.Welcome();
        while (true)
        {
            ui.ListOptionView();
            ui.ListOptions();
        }

        
    }
}