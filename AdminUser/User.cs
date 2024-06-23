using System.Runtime.ExceptionServices;
using AdminUser;
using postNamespace;
namespace userNamespace;
public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public User(int id, string name, string surname, int age, string email, string password)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.email = email;
        this.password = password;
    }
    public void showAllposts(List<Post> posts)
    {
            foreach (Post post in posts)
            {
                Console.WriteLine(post.ToString());
                Console.WriteLine();

        }
        Console.WriteLine();
    }
}

