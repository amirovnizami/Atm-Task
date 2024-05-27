
using Inheritance;

Cat cat = new Cat("Mesi", 4, "gender1", 4, 200, 10);
Dog dog = new Dog("Layka", 5, "gender3", 20, 500, 40);
Bird bird = new Bird("Buddy", 1, "gender4", 5, 150, 8);
Fish fish = new Fish("Dosi", 2, "gender2", 3, 20, 9);

List<Animal> animals = new List<Animal>();  

animals.Add(bird);
animals.Add(fish);
animals.Add(dog);
animals.Add(cat);

foreach (var animal in animals)
{
    Console .WriteLine();
    Console.WriteLine(animal);
}
//animals.Remove(bird);