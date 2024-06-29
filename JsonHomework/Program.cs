using JsonHomework;

using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;



void JsonSerializeMethod(List<Car>cars)
{

    JsonSerializerOptions op = new JsonSerializerOptions();
    op.WriteIndented = true;
    var jsonString = JsonSerializer.Serialize(cars, op);
    File.WriteAllText("cars.json", jsonString);
}
void JsonDesiriazlizeMethod()
{
    List<Car> cars = null;
    using FileStream fs = new FileStream("cars.json", FileMode.Open);
    cars = System.Text.Json.JsonSerializer.Deserialize<List<Car>>(fs);
    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }
}


List<Car> cars = new List<Car> {
        new Car(1,"Priora","Lada", 2013),
        new Car(2,"2107", "Lada",2011),
        new Car(3,"2106","LadA", 1999),
};
CarGallery carGallery = new CarGallery("Gallery1", cars);
Car car1 = new Car(4,"BMW","F10",2020);
carGallery.AddCar(car1);
//carGallery.RemoveCar(car1);
JsonSerializeMethod(cars);

carGallery.GetAllCar();

