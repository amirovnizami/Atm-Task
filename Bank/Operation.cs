namespace Atm;

public class Operation
{
    Guid operGuid = Guid.NewGuid();

    public Operation(Guid operGuid, string process_name, DateOnly dateTime)
    {
        this.operGuid = operGuid;
        this.process_name = process_name;
        this.dateTime = dateTime;
    }

    public string process_name { get; set; }
    public DateOnly dateTime { get; set; }

    
}
