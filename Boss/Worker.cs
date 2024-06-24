namespace Boss;
public class Worker:IEmployee
{

    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public string password { get; set; }
    public string city { get; set; }
    public string phone { get; set; }
    public int age { get; set; }
    public CV cv { get; set; }
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Worker(int id, string name, string surname,string password,string city, string phone, int age, CV cv)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.password = password;
        this.city = city;
        this.phone = phone;
        this.age = age;
        this.cv = cv;
    }

}
