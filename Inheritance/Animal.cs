
namespace Inheritance;

public class Animal
{
    public Animal(string nickName, int age, string gender, int energy, decimal price, int mealQuantity)
    {
        NickName = nickName;
        Age = age;
        Gender = gender;
        Energy = energy;
        Price = price;
        MealQuantity = mealQuantity;
    }

    public string NickName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public int Energy { get; set; }
    public decimal Price { get; set; }
    public int MealQuantity { get; set; }

    public virtual void eat()
    {
        Console.WriteLine("Animal is eating.");
        Energy++;
        MealQuantity--;
        Price+=10;
    }
    public virtual void sleep()
    {
        if (Energy == 0)
        {
            Console.WriteLine("Animal is sleeping.");
        }
        else
        {
            Console.WriteLine("Yet Animal has energy enough!");
        }
    }
    public virtual void play()
    {
        Console.WriteLine("Animal is playing.");
        Energy--;
    }

    public override string? ToString()
    {
        return $"Nickname:{NickName}\nAge:{Age}\nGender:{Gender}\nEnergy:{Energy}\nPrice:{Price}\nMeal Quantity:{MealQuantity}";
    }

  
}
