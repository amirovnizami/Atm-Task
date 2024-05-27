namespace Inheritance
{
    public class Dog : Animal
    {
        public Dog(string nickName, int age, string gender, int energy, decimal price, int mealQuantity) : base(nickName, age, gender, energy, price, mealQuantity)
        {
        }
        public override void eat()
        {
            base.eat();
        }
        public override void play()
        {
            base.play();
        }

        public override void sleep()
        {
            base.sleep();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
