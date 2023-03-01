using System.Threading.Channels;

namespace Project;

internal class Library
{
    private Book[] _books;
    private int _current_book;
    public Library()
    {
        this._books = new Book[100];
        this._current_book = 0;
    }

    public void Add_Book()
    {
        Take_Information(out string isbn, out string title, out string authorName, out int noPage);
        Book New_Book = new Book(isbn, title, authorName, noPage);
        this._books[this._current_book++] = New_Book;
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

    public void List_Available_Books()
    {
        Console.WriteLine($"Our Current book collection: ");
        for (int i = 0; i < this._current_book; i++)
        {
            Console.WriteLine($"{i + 1}- {this._books[i]._title}");
        }
    }
}