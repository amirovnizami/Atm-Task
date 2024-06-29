namespace JsonHomework;

public class Car
{
    public Car(int id, string model, string marka, int year)
    {
        Id = id;
        Model = model;
        Marka = marka;
        Year = year;
    }

    public int Id { get; set; }
    public string Model { get; set; }
    public string Marka { get; set; }
    public int Year { get; set; }

    public override string ToString()
    => $"{Marka}-{Model}-{Year}";
}
public class CarGallery
{
    public CarGallery(string name, List<Car> cars)
    {
        Name = name;
        Cars = cars;
    }

    public string Name { get; set; }
    public List<Car> Cars { get; set; }



    public void AddCar(Car car) { 
    
        Cars.Add(car);
    }
    public void RemoveCar(Car car) {
        Cars.Remove(car);
    }
    public void GetAllCar()
    {
        List<Car> cars = null;
        using FileStream fs = new FileStream("cars.json", FileMode.Open);
        cars = System.Text.Json.JsonSerializer.Deserialize<List<Car>>(fs);
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public Car GetById(int id)
    {
        foreach (var car in Cars)
        {
            if (id == car.Id)
            {
                return car;
            }
        }
        throw new NullReferenceException("Id is not found!!");

    }
}