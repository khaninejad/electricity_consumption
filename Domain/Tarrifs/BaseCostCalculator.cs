namespace Domain.Tarrifs
{
    public class BaseCostCalculator : Tariff
    {
        private const double BaseCostPerMonth = 5.0;

        public BaseCostCalculator(long kwPerYear)
        {
            TariffName = "Base Cost";
            AnnualCosts = BaseCostPerMonth * 12;
        }
    }
}
