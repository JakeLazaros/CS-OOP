using OOP.Class;

Console.Title = "Realistic Car Simulator";

var cars = new List<(string Brand, string Model)>
{
    ("BMW", "3 Series"),
    ("Honda", "Civic")
};

var randomCar = cars[new Random().Next(cars.Count)];

Car car = new Car(randomCar.Brand, randomCar.Model);

Console.WriteLine($"Make: {car.Make}");
Console.WriteLine($"Model: {car.Model}");

while (true)
{
    Console.Write("\nEnter 1 to start car: ");

    if(Console.ReadLine() == "1")
    {
        if (car.StartDrive())
        {
            Console.WriteLine("\nCar is running...");
            break;
        }
        else {
            Console.WriteLine("\nCar failed to run... try again.");
        }
    }
}