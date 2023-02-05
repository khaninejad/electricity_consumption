using Domain.Tarrifs;

namespace Domain.Tarrifs
{
    public class BasicElectricityTariffCalculator : Tariff
    {
        public BasicElectricityTariffCalculator(long kwPerYear)
        {
            TariffName = "Basic Electricity Tariff";
            var baseCost = new BaseCostCalculator(kwPerYear).AnnualCosts;
            var consumptionCost = new ConsumptionCostCalculator(kwPerYear).AnnualCosts;
            AnnualCosts = baseCost + consumptionCost;
        }
    }
}
