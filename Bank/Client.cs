namespace Atm;

public class Client
{
    Guid clientGuid = Guid.NewGuid();

    public Client(Guid clientGuid, string name, string surname, int age, string live_adress, string work_adress, int salary)
    {
        this.clientGuid = clientGuid;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.live_adress = live_adress;
        this.work_adress = work_adress;
        this.salary = salary;
    }

    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; }
    public string live_adress { get; set; }
    public string work_adress { get; set; }
    public int salary { get; set; }
}
