
using Domain;
Console.WriteLine($"***********************************Domain1********************************************\n\n");

ElectricityComairation electricityComairation = new ElectricityComairation();

var tarris = electricityComairation.Consumption(3500);
foreach (var item in tarris)
{
    Console.WriteLine($"Consumption for {item.TarrifName} is {item.AnnualCosts}");
}

tarris = electricityComairation.Consumption(4500);
foreach (var item in tarris)
{
    Console.WriteLine($"Consumption for {item.TarrifName} is {item.AnnualCosts}");
}

tarris = electricityComairation.Consumption(6000);
foreach (var item in tarris)
{
    Console.WriteLine($"Consumption for {item.TarrifName} is {item.AnnualCosts}");
}

Console.ReadKey();