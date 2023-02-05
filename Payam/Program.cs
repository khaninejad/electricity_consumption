
using Domain;
Console.WriteLine($"***********************************Domain1********************************************\n\n");

ElectricityComparison electricityComparison = new ElectricityComparison();

var tarris = electricityComparison.Compare(3500);
foreach (var item in tarris)
{
    Console.WriteLine($"Consumption for {item.TariffName} is {item.AnnualCosts}");
}

tarris = electricityComparison.Compare(4500);
foreach (var item in tarris)
{
    Console.WriteLine($"Consumption for {item.TariffName} is {item.AnnualCosts}");
}

tarris = electricityComparison.Compare(6000);
foreach (var item in tarris)
{
    Console.WriteLine($"Consumption for {item.TariffName} is {item.AnnualCosts}");
}

Console.ReadKey();