namespace Project;

internal class Admin: User
{
    public Admin(string userName, string password, string name, string email, bool isAdmin): base(userName, password, name, email, isAdmin)
    {
        
    }
    public Book Add_Book()
    {
        Take_Information(out string isbn, out string title, out string authorName, out int noPage);
        Book New_Book = new Book(isbn, title, authorName, noPage);
        return New_Book;
    }

    private void Take_Information(out string isbn, out string title, out string authorName, out int noPage)
    {
        Console.Write($"Enter ISBN: ");
        isbn = Console.ReadLine();
        Console.Write($"Enter Title: ");
        title = Console.ReadLine();
        Console.Write($"Enter Author Name: ");
        authorName = Console.ReadLine();
        Console.Write($"Enter  How Many Pages: ");
        noPage = int.Parse(Console.ReadLine());
    }
}