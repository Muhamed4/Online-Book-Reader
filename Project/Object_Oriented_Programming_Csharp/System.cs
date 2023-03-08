 namespace Project;

internal class System: ISystem
{
    private Library _library;
    private Customer[] _customers;
    private Admin _admins;
    private int current_user;
    private delegate bool Check_Choice(int _chioce);
    public System()
    {
        this._admins = new Admin("Muhamed_Morsi", "muhamed123", "Muhamed", "mohamedmorsi@gmail.com");
        this._customers = new Customer[100];
        this._library = new Library();
        current_user = 0;
    }
    
    public void RunSystem()
    {
        // Adding Some Books in the system
        Add_Some_Books_To_System();
        
        int Choice = Show_Menu();
        
        if (Choice == 1)
        {
            Log_In();
        }
        else
        {
            Sign_Up();
        }
    }

    private void Add_Some_Books_To_System()
    {
        Book book1 = this._admins.Add_Book();
        Book book2 = this._admins.Add_Book();
    }

    private int Show_Menu()
    {
        Console.WriteLine($"\t{1}: Login");
        Console.WriteLine($"\t{2}: Sign Up");
        int _choice = 0;
        Get_Choice(ref _choice, $"Enter number in range {1} - {2}: ", delegate(int chioce) { return chioce < 1 || chioce > 2; });
        return _choice;
    }

    private void Log_In()
    {
        
    }

    private void Sign_Up()
    {
        bool Information_Right = false;
        string user_name, password, name, email;
        do
        {
            Console.Write("Enter user name:");
            user_name = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
            Information_Right = false;
            for (int i = 0; i < current_user; i++)
            {
                if (this._customers[i]._userName == user_name || this._customers[i]._email == email)
                {
                    Information_Right = true;
                    break;
                }
            }

            if (Information_Right == true)
            {
                Console.WriteLine("This Information is already Exist...!");
            }
        } while (Information_Right == false);
        Customer NewCustomer = new Customer(user_name, password, name, email, false);
        this._customers[current_user++] = NewCustomer;
    }

    private void Get_Choice(ref int _choice, string title, Check_Choice checkChioce)
    {
        Console.WriteLine(title);
        if (int.TryParse(Console.ReadLine(), out _choice))
        {
            if (checkChioce(_choice))
            {
                Console.WriteLine($"Not Invalid Range, Try again....!");
                Get_Choice(ref _choice, title, checkChioce);
            }
        }
        else
        {
            Console.WriteLine($"Not Invalide Number, Try again....!");
            Get_Choice(ref _choice, title, checkChioce);
        }
    }

    private void User_View(Customer Current_User)
    {
        Console.WriteLine($"Hello {Current_User._userName} | User View");
        Console.WriteLine("Menu");
        Console.WriteLine("\t1: View Profile");
        Console.WriteLine("\t2: List & Select from My Reading History");
        Console.WriteLine("\t3: List & Select from Available Books");
        Console.WriteLine("\t4: Logout");
        int _choice = 0;
        Get_Choice(ref _choice, "Enter number in range 1 - 4: ", delegate(int _choice) { return _choice < 1 || _choice > 4; });
        
    }
}