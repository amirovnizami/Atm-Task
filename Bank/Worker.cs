using System.Numerics;

namespace Atm;

public class Worker
{
    Guid workerGuid = Guid.NewGuid();

    public Worker(Guid workerGuid, string name, string surname, int age, string position, string salary, DateOnly startTime, DateOnly endTime, List<Operation> operations)
    {
        this.workerGuid = workerGuid;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.position = position;
        this.salary = salary;
        this.startTime = startTime;
        this.endTime = endTime;
        this.operations = operations;
    }

    public string name { get; set; }
    public string surname {  get; set; }
    public int age { get; set; }
    public string position { get; set; }
    public string salary { get; set; }

    public DateOnly startTime { get; set; }
    public DateOnly endTime { get; set; }

    List<Operation> operations { get; set; }

    void addOperation(Operation operation) {
        operations.Add(operation);
    }
}
