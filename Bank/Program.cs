using Atm;

CEO ceo = new CEO("Dmith", "Holshuns", 29, "position1", 3000);
Client client1 = new Client(Guid.NewGuid(),"John","Johnson",27,"Baku City","Baku",2000);
Client client2 = new Client(Guid.NewGuid(),"Jony","Smith",30,"Baku City","Baku",3000);

Credit credit1 = new Credit(Guid.NewGuid(),client1,10000,8,12,400);
Credit credit2 = new Credit(Guid.NewGuid(),client2,20000,6,18,300);

List<Client> clients = new List<Client>();
List<Credit> credits = new List<Credit>();
clients.Add(client1);
clients.Add(client2);
credits.Add(credit1);
credits.Add(credit2);
Bank bank1 = new Bank("Bank1", 300000000, 2000000, ceo, credits, new List<Worker>(), new List<Manager>(), clients);

//Console.WriteLine(credit1.ToString());

bank1.showCilentCredit("Jony");
bank1.payCredit(client2,999);
bank1.showCilentCredit("Jony");

//bank1.showAllCredits(credits);