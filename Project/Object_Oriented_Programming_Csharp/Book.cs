namespace Project;

internal class Book
{
    public string _isbn { get; private set; }
    public string _title { get; private set; }
    public string _author_name { get; private set; }
    public int _no_page { get; private set; }
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
    }

    public void Add_Page()
    {
        
    }

    public string Get_Content()
    {
        return "";
    }

    public string Next_Page()
    {
        return "";
    }

    public string Previous_Page()
    {
        return "";
    }
}