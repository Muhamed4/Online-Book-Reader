namespace Project;

internal class System
{
    private Library _library;
    private Customer[] _customers;
    private Admin[] _admins;

    public System()
    {
        this._admins = new Admin[100];
        this._customers = new Customer[100];
        this._library = new Library();
    }
    
    public void RunSystem()
    {
        int Choice = Show_Menu(); 
    }

    private int Show_Menu()
    {
        Console.WriteLine($"\t{1}: Login");
        Console.WriteLine($"\t{2}: Sign Up");
        Console.Write($"Enter number in range {1} - {2}: ");
        if (int.TryParse(Console.ReadLine(), out int _choice))
        {
            if (_choice < 1 || _choice > 2)
            {
                Console.WriteLine($"Not Invalid Range, Try again....!");
                Show_Menu();
            }
        }
        else
        {
            Console.WriteLine($"Not Invalide Number, Try again....!");
            Show_Menu();
        }

        return _choice;
    }

    private void Log_In()
    {
        
    }

    private void Sign_Up()
    {
        
    }
}