
var a1 = new Author();
a1.Name = "Tom";
a1.Age = 15;
a1.Nationality = "russian";

a1.GetName();
System.Console.WriteLine($"Age: {a1.GetAge()}");
a1.Introduce();
a1.CelebrateBirthday();



public class Author
{
    public string Name;
    public int Age;
    public string Nationality;

    public Author() { }

    public Author(string _name, int _age)
    {
        _name = Name;
        _age = Age;
    }

    public Author(string _name, int _age, string _nationality)
    {
        _name = Name;
        _age = Age;
        _nationality = Nationality;
    }

    public void GetName()
    {
        System.Console.WriteLine($"Name: {Name}");
    }
    public int GetAge()
    {
        return Age;
    }
    public void Introduce()
    {
        System.Console.WriteLine($"Меня зовут {Name}. Мне {Age} лет. Я из {Nationality}");
    }
    public void CelebrateBirthday()
    {
        System.Console.WriteLine($"{Age + 1}");
    }
}