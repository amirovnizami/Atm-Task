using System.Buffers;
using System.Drawing;

public class BankCard
{
    public BankCard(string bankName, string fullName, string pAN, string pIN, DateOnly expireDate)
    {
        Random rand = new Random();
        BankName = bankName;
        FullName = fullName;
        PAN = pAN;
        PIN = pIN;
        CVC = rand.Next(100, 1000);
        ExpireDate = expireDate;
        Balans = rand.Next(0, 5000);
    }

    public string BankName { get; set; }
    public string FullName { get; set; }
    public string PAN { get; set; }
    public string PIN { get; set; }
    public int CVC { get; set; }
    public DateOnly ExpireDate { get; set; }
    public double Balans { get; set; }
}

public class Client
{
    public Client(int id, string name, string surname, int age, int salary, BankCard bankCardAccount)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.salary = salary;
        this.bankCardAccount = bankCardAccount;
    }

    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; }
    public int salary { get; set; }
    public BankCard bankCardAccount { get; set; }

    public string ShowClient()
    {
        return $"Id :{id}\nName: {name}\nSurname :{surname}\nAge :{age}\nSalary :{salary}\nBank: \nBankName: {bankCardAccount.BankName}\nFullName: {bankCardAccount.FullName}\nPan: {bankCardAccount.PAN}\nPin: {bankCardAccount.PIN}\nCvc: {bankCardAccount.CVC}\nBalance: {bankCardAccount.Balans}";
    }
}

public class Bank
{
    private List<Client> clients = new List<Client>();

    public void AddClient(Client client)
    {
        clients.Add(client);
    }

    public void ShowCardBalance()
    {
        foreach (var client in clients)
        {
            Console.WriteLine(client.ShowClient());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DateOnly expireDate = new DateOnly(2024, 12, 31);
        BankCard bankcard1 = new BankCard("Kapital", "Nizami Amirov", "123131314324234", "1881", expireDate);
        Client client1 = new Client(1, "Nizami", "Amirov", 20, 2000, bankcard1);

        Bank bank = new Bank();

        bank.AddClient(client1);

        bank.ShowCardBalance();
    }
}
