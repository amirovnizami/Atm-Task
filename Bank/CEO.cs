
namespace Atm;

public class CEO
{

    public string name { get; set; }
    public string surname { get; set; }

    public int age { get; set; }
    public string position { get; set; }
    public int salary { get; set; }
    public CEO(string name, string surname, int age, string position, int salary)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.position = position;
        this.salary = salary;
    }
    public void control() {
        Console.WriteLine("Is being controlled");
    }
    public void organize() {
        Console.WriteLine("Is being organized");
    }
    public void makeMeeting() {
        Console.WriteLine("Make meeting!!");
    }
    public void decreasePercentage(int percent) {
        Console.WriteLine("Percentage was recuded!");
    }

}
