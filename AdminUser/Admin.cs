namespace adminNamespace;

using AdminUser;
using postNamespace;
public class Admin { 
    public int id { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public List <Post>posts { get; set; }
    public List<Notification> notifacations { get; set; }

    public Admin(int id, string username, string email, string password, List<Post> posts, List<Notification> notifacations)
    {
        this.id = id;
        this.username = username;
        this.email = email;
        this.password = password;
        this.posts = posts;
        this.notifacations = notifacations;
    }
    public void addNoticifation(Notification notf)
    {
        notifacations.Add(notf);
    }
    public string showAdminInfo()
    {
        return $"Id: {id}\nUsername: {username}\nEmail: {email}\nPassword :{password}\nPosts : posts \n ";
    }
    public void showNotf()
    {
        foreach (var not in notifacations)
        {
            Console.WriteLine(not.ToString());
        }
    }
}
