namespace LinqQueries;

public class Debtor
{
    public string FullName { get; set; }
    public DateTime BirthDay { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Adress { get; set; }
    public int Debt { get; set; }
    public override string ToString()

    {
        return $"{this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Adress} {this.Debt}";
    }
    public Debtor(string fullName, DateTime birthDay, string phone, string email, string adress, int debt)
    {
        FullName = fullName;
        BirthDay = birthDay;
        Phone = phone;
        Email = email;
        Adress = adress;
        Debt = debt;
    }
}