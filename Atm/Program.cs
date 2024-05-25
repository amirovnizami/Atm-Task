using System.Buffers;
using System.Xml.Serialization;

class Program
{

    class Atm
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

        //static void Main(string[] args)

        void cashIn()
        {
            Console.Write("Mebleg girin : ");
            int add = int.Parse(Console.ReadLine());
            balace += add;
        }
        void showBalance()
        {
            Console.WriteLine($"Balance: {balace}");


        }
        void cashOut()
        {
            Console.Write("Mebleg girin : ");
            int add = int.Parse(Console.ReadLine());
            if (add > balace)
            {
                Console.WriteLine("Balansinizda kifayet qeder mebleg yoxdur!");
            }
            balace -= add;
        }
        void changePas()
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
            }
        }

        int count = 0;
        public void Check()
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
            if(count == 3)
            {
                Console.WriteLine("Card blocked!!!");
            }

        }
        void Display()
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
    static void Main(string[] args)
    {
        Atm atm1 = new("nizami1234", 1000);
        atm1.Check();
    }
}

