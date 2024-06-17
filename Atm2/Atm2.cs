
namespace Atm2;
public class Atm
{

    private string pin;
    private int balace;

    public Atm(string pin, int balance)

    {
        this.pin = pin;
        this.balace = balance;
    }
    public string Pin { get { return pin; } set { pin = value; } }
    public int Balace { get { return balace; } set { balace = value; } }


    public void cashIn()
    {
        Console.Write("Mebleg girin : ");
        int add = int.Parse(Console.ReadLine());
        balace += add;
    }
    public void showBalance()
    {
        Console.WriteLine($"Balance: {balace}");


    }
    public void cashOut()
    {
        try
        {
            Console.Write("Mebleg girin : ");
            int add = int.Parse(Console.ReadLine());
            if (add > balace)
            {
                throw new Exception("Kifayet qeder balansiniz yoxdur!");
            }
            balace -= add;
        }
        catch (FormatException)
        {
            Console.WriteLine("Daxil etdiyiniz format duzgun deyil!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Xeta: {e}");
        }

    }
    public void changePas()
    {
        try
        {
            int count = 0;
            while (count<=3)
            {
                Console.Write("Old Pin : ");
                string oldPin = Console.ReadLine();
                if (oldPin == pin)
                {
                    Console.Write("New Pin : ");
                    string newPin = Console.ReadLine();
                    pin = newPin;
                }
                else
                {
                    Console.WriteLine("Old pin is incorrect!");
                    count++;  
                }
            }
            throw new Exception("Kart bloklandi!");
           
        }
        catch (Exception e)
        {

            Console.WriteLine($"Xeta {e}");
        }
    }

    int count = 0;
    public void Check()
    {
        try
        {
            while (count < 3)
            {
                Console.Write("Enter Pin : ");
                string entertPin = Console.ReadLine();
                if (entertPin == pin)
                {
                    Display();

                }
                else
                {
                    Console.WriteLine("Incorrect Pin!!!");
                    count++;
                }

            }
            if (count == 3)
            {
                throw new Exception("3 defeden artiq cehd etdiniz.Kart bloklandi!");
            }

        }
        catch (Exception e)
        {

            Console.WriteLine($"Xeta {e}");
        }
        }
    public void Display()
    {
        Console.WriteLine("Choices : ");
        Console.WriteLine("1.CahsIn ");
        Console.WriteLine("2.CashOut ");
        Console.WriteLine("3.ShowBalance ");
        Console.WriteLine("4.Change Password ");

        Console.Write("Your choice : ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            cashIn();
        }

        else if (choice == "2")
        {
            cashOut();
        }

        else if (choice == "3")
        {
            showBalance();
        }

        else if (choice == "4")
        {
            changePas();
        }
        else
        {
            Console.WriteLine("Incorrect Choice!");
        }


    }

}