var u1 = new User();
u1.FirstName = "Steve";
u1.LastName = "Jobs";
u1.Username = "user12345";
u1.Password = "user12345";
u1.IsLoggedIn = true;

u1.Login();
u1.Logout();
System.Console.WriteLine(u1.GetFullInfo());
public class User
{
    public string FirstName;
    public string LastName;
    public string Username;
    public string Password;
    public bool IsLoggedIn;


    public void Login()
    {
        if (Username == Password)
            System.Console.WriteLine($"Пользователь успешно зарегистрирован ");
        else
        {
            System.Console.WriteLine($"Ваш пароль или имя пользователя неверны");
        }
    }
    public void Logout()
    {
        bool t = true;
        bool f = false;
        if (Username == Password)
            System.Console.WriteLine(f);
        else
            System.Console.WriteLine(t);
    }
    public string GetFullInfo()
    {
        return $"{FirstName} {LastName} - {IsLoggedIn}";
    }
}
