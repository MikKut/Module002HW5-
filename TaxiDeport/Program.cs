using TaxiDeportProgram.Models;
using TaxiDeportProgram.Models.CarTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        int id = 1;
        PassengerСar[] cars = new PassengerСar[]
        {
    new LuxaryCar(name: "A", description: "LA", price: 2.3M, id: id++, fuelConsumptionLiterPerHundredKm: 2.1M, mileage: 3.2M),
    new LuxaryCar(name: "B", description: "LB", price: 2.4M, id: id++, fuelConsumptionLiterPerHundredKm: 2.2M, mileage: 3.2M),
    new WorkerCar(name: "A", description: "WA", price: 1.3M, id: id++, fuelConsumptionLiterPerHundredKm: 1.5M, mileage: 4.2M),
    new WorkerCar(name: "B", description: "WB", price: 1.0M, id: id++, fuelConsumptionLiterPerHundredKm: 1.7M, mileage: 4.8M),
    new MiddleClassCar(name: "A", description: "MA", price: 1.8M, id: id++, fuelConsumptionLiterPerHundredKm: 1.5M, mileage: 4.2M)
        };

        TaxiDeport deport = new TaxiDeport(cars);
        if (!deport.AddCar(new LuxaryCar(name: "A", description: "LA", price: 2.3M, id: 1, fuelConsumptionLiterPerHundredKm: 2.1M, mileage: 3.2M)))
        {
            Console.WriteLine("Cannot add the same car");
        }

        Console.WriteLine($"{deport.GetCarById(2) !.Name} has id 2 and tax {deport.GetCarById(2) !.Tax}");
        Console.WriteLine();
        Console.WriteLine("Before sorting:");
        foreach (var x in deport.PassengerСars)
        {
            Console.WriteLine($"{x.FuelConsumptionLiterPerHundredKm} - {x.Name}");
        }

        Console.WriteLine("\nAfter sorting:");
        deport.SortByFuelConsumption();
        foreach (var x in deport.PassengerСars)
        {
            Console.WriteLine($"{x.FuelConsumptionLiterPerHundredKm} - {x.Name}");
        }
    }
}