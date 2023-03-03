namespace Project;

internal class Customer: User
{
    public Customer(string userName, string password, string name, string email, bool isAdmin): base(userName, password, name, email, isAdmin)
    {
        
    }
}