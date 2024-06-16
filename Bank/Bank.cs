namespace Atm;

public class Bank
{
    public string Name { get; set; }
    public int Budget { get; set; }
    public int Profit { get; set; }
    public CEO ceo { get; set; }
    List<Credit> credits { get; set; }
    List<Worker> workers { get; set; }
    List<Manager> manager { get; set; }
    List<Client> clients { get; set; }
    public Bank(string name, int budget, int profit, CEO ceo, List<Credit> credits, List<Worker> workers, List<Manager> manager, List<Client> clients)
    {
        Name = name;
        Budget = budget;
        Profit = profit;
        this.ceo = ceo;
        this.credits = credits;
        this.workers = workers;
        this.manager = manager;
        this.clients = clients;
    }


    public void Calculat_profit()
    {
        Console.WriteLine($"Bank get profit :{Profit}");
    }

    public void showCilentCredit(string name)
    {

        foreach (Client client in clients)
        {
            if (name == $"{client.name}")
            {
                foreach(Credit credit in credits)
                {
                    if(credit.client == client)
                    {
                        Console.WriteLine(credit.ToString());

                    }
                }

            }
        }
    }

    public void showAllCredits(List<Credit> credits)
    {
        foreach (Credit credit in credits)
        {
            Console.WriteLine(credit.ToString() );
        }
    }

    public void payCredit(Client client, int money) { 
        foreach (Credit credit in credits)
        {
            if(credit.client == client)
            {
                credit.amount -=money;
            }
        }
    }

}

