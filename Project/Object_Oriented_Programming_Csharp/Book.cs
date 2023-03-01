namespace Project;

internal class Book
{
    public string _isbn { get; private set; }
    public string _title { get; private set; }
    public string _author_name { get; private set; }
    public int _no_page { get; private set; }
    private int _current_page;
    private Page[] _pages;
    class Page
    {
        public string _content { get; private set; }
        public int _no { get; private set; }

        public Page(string content, int no)
        {
            this._content = content;
            this._no = no;
        }
    }

    public Book(string isbn, string title, string author_name, int noPage)
    {
        this._isbn = isbn;
        this._title = title;
        this._author_name = author_name;
        this._no_page = noPage;
        this._pages = new Page[this._no_page];
        this._current_page = 0;
        this.Add_Pages();
    }

    private void Add_Pages()
    {
        for (int i = 0; i < this._no_page; i++)
        {
            Console.Write($"Enter Page #{i}: ");
            string Content = Console.ReadLine();
            Page New_Page = new Page(Content, i + 1);
            this._pages[i] = New_Page;
        }
    }

    private string Get_Content()
    {
        return this._pages[this._current_page]._content;
    }

    public string Next_Page()
    {
        if (this._current_page < this._no_page)
        {
            ++this._current_page;
        }
        return this.Get_Content();
    }

    public string Previous_Page()
    {
        if (this._current_page > 0)
        {
            --this._current_page;
        }
        return this.Get_Content();
    }
}