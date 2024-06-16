namespace Atm;

public class Credit
{
    Guid creditGuid = Guid.NewGuid();

    public Credit(Guid creditGuid, Client client, int amount, int percents, int months, int payment)
    {


        this.creditGuid = creditGuid;
        this.client = client;
        this.amount = amount;
        this.percents = percents;
        this.months = months;
        this.payment = payment;
    }

    public Client client { get; set; }
    public int amount { get; set; }
    public int percents { get; set; }
    public int months { get; set; }
    public int payment { get; set; }
    public float CalculatePercent()
    {
        float result = (amount * percents) / 100;
        return result;
    }

    public  string ToString()
    {
        return $"Guid: {creditGuid}\nClientName :{client.name}\nAmount :{amount}\nPercent:{percents}\n";
    }
}