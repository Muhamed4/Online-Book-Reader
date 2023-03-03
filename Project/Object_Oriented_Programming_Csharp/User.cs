namespace Project;

internal abstract class User
{
    public string _userName { get; private set; }
    public string _password { get; private set; }
    public string _name { get; private set; }
    public string _email { get; private set; }
    public readonly bool _isAdmin;

    public User(string userName, string password, string name, string email, bool isAdmin)
    {
        this._userName = userName;
        this._password = password;
        this._name = name;
        this._email = email;
        this._isAdmin = isAdmin;
    }
}