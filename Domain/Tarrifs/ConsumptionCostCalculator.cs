using Domain.Tarrifs;

namespace Domain.Tarrifs
{
    public class ConsumptionCostCalculator : Tariff
    {
        private const double RatePerKw = 0.22;

        public ConsumptionCostCalculator(long kwPerYear)
        {
            TariffName = "Consumption Cost";
            AnnualCosts = RatePerKw * kwPerYear;
        }
    }
}