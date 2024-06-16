namespace Atm
{
    public class Manager
    {
        Guid managerGuid = Guid.NewGuid();

        public Manager(Guid managerGuid, string name, string surname, int age, string position, string salary)
        {
            this.managerGuid = managerGuid;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.position = position;
            this.salary = salary;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string position { get; set; }
        public string salary { get; set; }
        public void organize() {
            Console.WriteLine("Is being organized!");
        }
        public void calculateSalaries() {
            Console.WriteLine("Calcuting salaries!");
        }
    }
}
