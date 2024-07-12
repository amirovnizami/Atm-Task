
namespace Hospital;

public  class User
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Number { get; set; }
    public User(string name, string surname, string email, string number)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Number = number;
    }
}
