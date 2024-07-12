using Hospital;
using Sobeler;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Channels;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
Dictionary<int, bool> CreateSaatlar()
{
    return new Dictionary<int, bool>
    {
        {1, false },
        {2, false },
        {3, false }
    };
}
Hekim hekim1 = new Hekim("Elvin", "Eliyev", 10, CreateSaatlar());
Hekim hekim2 = new Hekim("Elnur", "Mustafayev", 10, CreateSaatlar());
Hekim hekim3 = new Hekim("Fuad", "Qfarov", 10, CreateSaatlar());
Hekim hekim4 = new Hekim("Vusal", "Qiyasov", 10, CreateSaatlar());
Hekim hekim5 = new Hekim("Gulcin", "Eliyeva", 10, CreateSaatlar());
Hekim hekim6 = new Hekim("Sebine", "Memmedova", 10, CreateSaatlar());
Hekim hekim7 = new Hekim("Mahmud", "Memmedov", 10, CreateSaatlar());
Hekim hekim8 = new Hekim("Samir", "Samirli", 10, CreateSaatlar());
Hekim hekim9 = new Hekim("Vusal", "Agayev", 10, CreateSaatlar());
Hekim hekim10 = new Hekim("Eli ", "Qurbanov", 10, CreateSaatlar());
Hekim hekim11 = new Hekim("Elcin", "Emnullayev", 10, CreateSaatlar());
Hekim hekim12 = new Hekim("Aysel", "Rehimova", 10, CreateSaatlar());
Hekim hekim13 = new Hekim("Rena", "Qurbanova", 10, CreateSaatlar());


List<User> users = new List<User>();
List<Hekim> hekimler = new List<Hekim>() { hekim1, hekim2, hekim3, hekim4, hekim5, hekim6, hekim7, hekim8, hekim9, hekim10, hekim11, hekim12, hekim13 };
List<Hekim> pedHekim = new List<Hekim>() { hekim1, hekim2, hekim3, hekim4, hekim5 };
List<Hekim> travHekim = new List<Hekim>() { hekim6, hekim7, hekim9,hekim13 };
List<Hekim> stamoHekim = new List<Hekim>() { hekim8, hekim10, hekim11, hekim12 };

Pediatriya pediatriya = new Pediatriya("Pediartiya Sobesi", 5, pedHekim);
Travmatologiya travmatologiya = new Travmatologiya("Travmatalogiya sobei", 4, travHekim);
Stamotologiya stamotologiya = new Stamotologiya("Stamatologiya sobesi", 4, travHekim);


void GetUserInformation()
{
        try
        {
            Console.WriteLine("--------Melumatlarinizi daxil edin--------");
            Console.Write("Ad : ");
            var ad = Console.ReadLine();
            Console.Write("Soyad : ");
            var soyad = Console.ReadLine();
            Console.Write("Email : ");
            var email = Console.ReadLine();
            Console.Write("Telefon : ");
            var telefon = Console.ReadLine();
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
            {
                throw new EmptyFieldException("Istifadeci melumatlarini duzgun doldurun..");
            }
            users.Add(new User(ad, soyad, email, telefon));
            SelectionDepartment();
        }
        catch (EmptyFieldException ex)
        {
            Console.WriteLine(ex.Message);
            GetUserInformation();

    }

}


void SelectionDepartment()
{
    try
    {
        Console.WriteLine("--------Zehmet olmasa asagidaki sobelerden birini secin-------- ");
        Console.WriteLine("1.Pediatriya");
        Console.WriteLine("2.Travmatologiya");
        Console.WriteLine("3.Stamotologiya");
        Console.Write("Sobe : ");
        var sobe = Console.ReadLine();

        Console.WriteLine("Secdiyiniz sobede olan hekimler: ");

        if (sobe == "1")
        {
            foreach (var item in pedHekim)
            {
                Console.WriteLine(item.ToString());
            }
        }
        else if (sobe == "2")
        {
            foreach (var item in travHekim)
            {
                Console.WriteLine(item.ToString());
            }
        }
        else if (sobe == "3")
        {
            foreach (var item in stamoHekim)
            {
                Console.WriteLine(item.ToString());
            }
        }

        else
        {
            throw new InvalidChoiceException("Ugursuz secim!");
        }

    }
    catch (InvalidChoiceException ex) {
        Console.WriteLine(ex.Message);
    }
    SelectionDoctor();


}

void SelectionDoctor()
{
    try
    {
        Console.Write("Hansi hekimi secirsiz? (Adi ) : ");
        var secim = Console.ReadLine();
        bool hekimFound = false;
        Hekim secilenHekim = null;  
        foreach (Hekim item in hekimler)
        {
            if (item.Name == secim)
            {
                secilenHekim = item;
                hekimFound = true;
                Console.WriteLine(secilenHekim.Saatlar[1] ? "1)09:00-11:00(Rezerv olunub)" : "1)09:00-11:00(Rezerv olunmayib)");
                Console.WriteLine(secilenHekim.Saatlar[2] ? "2)12:00-14:00 (Rezerv olunub)" : "2)12:00-14:00 (Rezerv olunmayib)");
                Console.WriteLine(secilenHekim.Saatlar[3] ? "3)15:00-17:00 (Rezerv olunub)" : "3)15:00-17:00 (Rezerv olunmayib)");
                Console.Write("Qebul saatini secin : ");
                var qebulSaati = Console.ReadLine();
                try
                {
                    if (secilenHekim.Saatlar[int.Parse(qebulSaati)] == true)
                    {
                        Console.WriteLine("Bu saat artiq rezerv olunub,zehmet olmasa basqa saat secin!");
                        break;
                    }
                    string saat = "09:00 - 11:00";
                    if (qebulSaati == "1")
                    {

                        secilenHekim.Saatlar[1] = true;
                        saat = "09:00 - 11:00";


                    }
                    else if (qebulSaati == "2")
                    {
                        secilenHekim.Saatlar[2] = true;
                        saat = "12:00 - 14:00";

                    }
                    else if (qebulSaati == "3")
                    {
                        secilenHekim.Saatlar[3] = true;
                        saat = "15:00 - 17:00";

                    }
                    else
                    {
                        throw new KeyNotFoundException("Bu saatda qebul yoxdur!");
                    }

                    Console.WriteLine($"Siz {secim} hekimin`in qebuluna saat {saat}- ucun yazildiniz.");
                }
                catch (KeyNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Yalnis saat formati !");
                    continue;
                }
            }

        }
        if (hekimFound != true)
        {
            throw new NotFoundException("Sistemde Bele bir hekim yoxdur!");

        }
    }
    catch (InvalidChoiceException ex)
    {
        Console.WriteLine(ex.Message);

    }
    catch (NotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }

    catch (Exception ex) { Console.WriteLine(ex.Message); }

}

while (true)
{
    GetUserInformation();
    Console.Write("Davam etmek isteyirsiniz ? (H/Y) : ");
    var secim = Console.ReadLine();
    if(secim == "H")
    {
        GetUserInformation();
    }
    else
    {
        break;
    }
}

JsonSerializerOptions op = new JsonSerializerOptions();
op.WriteIndented = true;
var jsonString = JsonSerializer.Serialize(hekimler, op);
File.WriteAllText("hekimler.json", jsonString);

var jsonString1 = JsonSerializer.Serialize(users, op);
File.WriteAllText("istifadeciler.json", jsonString1);