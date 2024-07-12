public class Hekim
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int tecrube { get; set; }
    public Dictionary<int, bool> Saatlar { get; set; }
    public Hekim(string name, string surname, int tecrube,Dictionary<int,bool>saatlar)
    {
        Name = name;
        Surname = surname;
        this.tecrube = tecrube;
        Saatlar = saatlar;
    }
    public override string ToString()
    => $"Name: {Name}\nSurname : {Surname}";

}
