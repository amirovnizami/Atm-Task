namespace AdminUser;

public class Notification
{

    public int id { get; set; }
    public string Text { get; set; }
    public DateTime Date { get; set; }
    public string FromUser { get; set; }
    public Notification(int id, string text, DateTime date, string fromUser)
    {
        this.id = id;
        Text = text;
        Date = date;
        FromUser = fromUser;
    }

    public override string? ToString()
    {
        return $"Id: {id}\nText :{Text}\nDate :{Date}\nFromUser: {FromUser}";
    }
}
