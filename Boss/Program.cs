using Boss;

var vacancies = new List<string> { "Software", "Data analyst", "System Network" };
var skills = new List<string> { "C#", "C++", "Java", "Python", "JavaScript" };
var companies = new List<string> { "Google", "Microsoft", "Amazon", "Youtube" };
var languages = new List<string> { "Ingilis Dili -C1", "Fransiz Dili-A1", "Alman Dili -B2" };
var startDate = new DateOnly(2022, 1, 1);
var endDate = new DateOnly(2024, 12, 31);
CV cv1 = new CV("Computer Sciences", "150 N", 550, skills, companies, startDate, endDate, languages, true, "https://github.com/amirovnizami", "amirovnizami");
Worker worker1 = new Worker(1, "John", "Smith", "john1234", "Baku", "3211311", 29, cv1);
Worker worker2 = new Worker(2, "Jony", "Conor", "jony1234", "London", "23424234", 29, cv1);
Worker worker3 = new Worker(3, "Harry", "Charlie", "harry1234", "Paris", "546464", 29, cv1);

Empoyer employer = new Empoyer(1, "Charlie", "Smith", "Charlie1234", "London", "123123123", 35, vacancies);
List<Worker> workers = new List<Worker> {worker1,worker2,worker3 };
List<Empoyer> empoyers =  new List<Empoyer> {employer};
List<IEmployee>employees = new List<IEmployee> {worker1,worker2,worker3,employer };

void Sign()
{
    Console.Write("Username: ");
    string name = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();
    bool employeFound = false;
    try
    {
        foreach (var employee in employees)
        {
            if (employee is Worker)
            {
                foreach (var worker in workers)
                {
                    if (password == worker.password && name == worker.name)
                    {
                        employeFound = true;
                        workerDisplay();
                        break;
                      
                    }
                }

            }

            else if (employee is Empoyer)
            {
                foreach (var employer in empoyers)
                {
                    if (password == employer.password && name == employer.name)
                    {   
                        employeFound = true;   
                        employerDisplay();
                        break;
                    
                    }
                }
            }
            if (employeFound)
            {
                break;
            }
        }
        if (!employeFound)
        {
            throw new Exception("Sistemde bele istifadeci yoxdur.");
        }
        
    }
    catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
}

void workerDisplay()
{
    Console.WriteLine("Sign in is successfully as Worker!!");

}

void employerDisplay() {
    Console.WriteLine("Sign in is successfuly as Employee");
}

Sign();