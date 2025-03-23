using Microsoft.AspNetCore.Identity;

public class RegistrationRequest
{
    private string _email;

    private string _password;

    private string _role;

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }

    public string Role
    {
        get { return _role; }
        set { _role = value; }
    }
}