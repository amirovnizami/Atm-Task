namespace Boss;

public class CV
{

    public string ixtisas { get; set; }
    public string mekteb { get; set; }
    public int qebul_bali { get; set; }
    public List<string> skils { get; set; }
    public List<string> companies { get; set; }
    public DateOnly starDate { get; set; }
    public DateOnly endDate { get; set; }
    public List<string> languages { get;set; }
    public bool hasDiplom { get; set; }
    public string gitLink { get; set; }
    public string Linkedin { get; set; }
    public CV(string ixtisas, string mekteb, int qebul_bali, List<string> skils, List<string> companies, DateOnly starDate, DateOnly endDate, List<string> languages, bool hasDiplom, string gitLink, string linkedin)
    {
        this.ixtisas = ixtisas;
        this.mekteb = mekteb;
        this.qebul_bali = qebul_bali;
        this.skils = skils;
        this.companies = companies;
        this.starDate = starDate;
        this.endDate = endDate;
        this.languages = languages;
        this.hasDiplom = hasDiplom;
        this.gitLink = gitLink;
        Linkedin = linkedin;
    }
}; 
