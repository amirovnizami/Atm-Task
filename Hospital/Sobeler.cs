namespace Sobeler;
public class Pediatriya
{
    public string Sobead { get; set; }
    public int hekimSayi { get; set; }
    public List<Hekim> Ped_Hekimler { get; set; }
    public Pediatriya(string sobead, int hekimSayi, List<Hekim> ped_Hekimler)
    {
        Sobead = sobead;
        this.hekimSayi = hekimSayi;
        Ped_Hekimler = ped_Hekimler;
    }

    public override string? ToString()
   => $"Sobe ad {Sobead}\nHekim sayi {hekimSayi}\nHekimler:";
}
public class Travmatologiya
{
    public string Sobead { get; set; }
    public int hekimSayi { get; set; }

    public List<Hekim> Trav_Hekimler { get; set; }
    public Travmatologiya(string sobead, int hekimSayi, List<Hekim> trav_Hekimler)
    {
        Sobead = sobead;
        this.hekimSayi = hekimSayi;
        Trav_Hekimler = trav_Hekimler;
    }

}
public class Stamotologiya
{
    public string Sobead { get; set; }
    public int hekimSayi { get; set; }

    public List<Hekim> Stamo_Hekimler { get; set; }
    public Stamotologiya(string sobead, int hekimSayi, List<Hekim> stamo_Hekimler)
    {
        Sobead = sobead;
        this.hekimSayi = hekimSayi;
        Stamo_Hekimler = stamo_Hekimler;
    }

}
