using System;
using adminNamespace;
using userNamespace;
using postNamespace;
using AdminUser;
using System.ComponentModel.Design;
using System.Security;
using System.Reflection.Metadata;


List<Post> posts = new List<Post>();
List<Notification> notifications = new List<Notification>();
List<User> users = new List<User>();
List<Admin> admins = new List<Admin>();
string currentemail;
Post post1 = new Post(1, "Music", new DateTime(2003, 2, 10), 10, 100);
Post post2 = new Post(2, "Futbool", new DateTime(2010, 4, 8), 2, 50);
Post post3 = new Post(3, "Tennis", new DateTime(2012, 1, 10), 30, 200);
Post post4 = new Post(4, "Love", new DateTime(2013, 10, 12), 40, 5000);
Post post5 = new Post(5, "Animals", new DateTime(2017, 5, 9), 15, 600);

User user1 = new User(1, "John", "Smith", 20, "john204@mail.ru", "john1234");
User user2 = new User(2, "Jony", "Frlyster", 25, "jony123@mail.ru", "jony1234");
User user3 = new User(3, "Dobby", "Jonhson", 29, "dobby98@mail.ru", "dobby1234");

Admin admin = new Admin(1, "amirov", "amirovnizami395@gmail.com", "nizami1234", new List<Post>(), new List<Notification>());
admins.Add(admin);
users.Add(user1);
users.Add(user2);
users.Add(user3);


posts.Add(post1);
posts.Add(post2);
posts.Add(post3);
posts.Add(post4);
posts.Add(post5);

void likePost()
{
    try
    {
        Console.Write("Postun id-i girin: ");
        int id = int.Parse(Console.ReadLine());
        bool postFound = false;
        foreach (var post in posts)
        {
            if (post.id == id)
            {
                post.LikeCount += 1;
                post.ToString();
                postFound = true;
                break;
            }

        }
        if (!postFound)
        {
            throw new InvalidIdException("Bele id tapilmadi");
        }

    }
    catch (InvalidIdException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Notification notf1 = new Notification(1, "postunuzu beyendi", DateTime.Now, $"{currentemail}");
    notifications.Add(notf1);
    admin.addNoticifation(notf1);   
}
void viewPost()
{
    try
    {
        Console.Write("Postun id -i girin: ");
        int id = int.Parse(Console.ReadLine());
        bool postFound = false;
        foreach (var post in posts)
        {
            if (post.id == id)
            {
                post.ViewCount += 1;
                Console.WriteLine(post.ToString());
                postFound = true;

            }


        }
        if (!postFound)
        {
            throw new InvalidIdException("Bele id tapilmadi");
        }
    }

    catch (InvalidIdException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Notification notf2 = new Notification(2, "postunuzu izledi", DateTime.Now, $"{currentemail}");
    notifications.Add(notf2);
    admin.addNoticifation(notf2);
   

}
void signInAdmin()
{
    Console.Write("Email : ");
    string email = Console.ReadLine();
    currentemail = email;
    Console.Write("Password: ");
    string password = Console.ReadLine();
    try
    {
        foreach (Admin admin in admins)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new EmptyFieldException("Fill in the email and password fields");
            }
            if (password != admin.password)
            {
                throw new InvalidPasswordException("Incorrect Password!");
            }
            if (email != admin.email && email == null)
            {

                throw new InvalidEmailException("Email not found!");
            }
            Console.WriteLine("Sign in successful!!!");
            Console.WriteLine();

            Console.WriteLine("Choices: ");
            Console.WriteLine("1.Post elave etmek");
            Console.WriteLine("2.Post silmek");
            Console.WriteLine("3.Bildirisleri gormek");

            Console.Write("Choice : ");
            string choice = Console.ReadLine();
            if(choice == "3")
            {
                admin.showNotf();
            }
        }
    }
    catch (InvalidEmailException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (InvalidPasswordException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (EmptyFieldException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
void SignIn(List<User> users)
{
    Console.WriteLine("1.Admin");
    Console.WriteLine("2.User");
    Console.Write("Choice: ");
    string choice = Console.ReadLine();
    if(choice == "1")
    {
        signInAdmin();
    }
    if (choice == "2")
    {
        Console.Write("Email : ");
        string email = Console.ReadLine();
        currentemail = email;
        Console.Write("Password: ");
        string password = Console.ReadLine();
        try
        {
            foreach (User user in users)
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new EmptyFieldException("Fill in the email and password fields");
                }
                if (password != user.password)
                {
                    throw new InvalidPasswordException("Incorrect Password!");
                }
                if (email != user.email && email == null)
                {

                    throw new InvalidEmailException("Email not found!");
                }
                Console.WriteLine("Sign in successful!!!");
                Console.WriteLine();

                user.showAllposts(posts);
                break;
            }
        }
        catch (InvalidEmailException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (InvalidPasswordException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (EmptyFieldException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Display();
    }



}
void Display()
{
    while (true)
    {
        Console.WriteLine("Secimler : ");
        Console.WriteLine("1.Post beyenmek");
        Console.WriteLine("2.Post izlemek");
        Console.WriteLine("3.Cixis");

        Console.Write("Secim : ");
        string secim = Console.ReadLine();
        if (secim == "1")
        {
            likePost();
        }
        else if (secim == "2")
        {
            viewPost();
        }
        else if (secim == "3")
        {
            Console.WriteLine("Cixis edildi.");
            SignIn(users);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select 1, 2 or 3.");
        }

        //foreach (var post in posts)
        //{
        //    Console.WriteLine(post.ToString());
        //}
    }
}

SignIn(users);

