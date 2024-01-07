using System.Collections.Generic;
using System.Linq;

public class CarRepository
{
    private static List<Car> _cars = new List<Car>
    {
        new Car { Id = 1, Model = "Camry", Make = "Toyota", Description = "Comfortable sedan", RentalPrice = 50.00M, IsAvailable = true },
        new Car { Id = 2, Model = "Accord", Make = "Honda", Description = "Fuel-efficient sedan", RentalPrice = 55.00M, IsAvailable = true },
        new Car { Id = 3, Model = "Mustang", Make = "Ford", Description = "Sporty coupe", RentalPrice = 75.00M, IsAvailable = true },
        // Add more cars as needed
    };

    public List<Car> GetAllCars()
    {
        return _cars;
    }

    public Car GetCarById(int id)
    {
        return _cars.FirstOrDefault(c => c.Id == id);
    }

    public void RentCar(int id)
    {
        var car = _cars.FirstOrDefault(c => c.Id == id);
        if (car != null)
        {
            car.IsAvailable = false;
        }
    }
}