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

    public void Add_Book(Book book)
    {
        this._books[_current_book++] = book;
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