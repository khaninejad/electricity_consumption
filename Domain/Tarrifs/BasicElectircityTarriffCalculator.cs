namespace Domain.Tarrifs
{
    public class BasicElectircityTarriffCalculator : Tarrif
    {
        private const double baseCostPerMonth = 5.0;
        public BasicElectircityTarriffCalculator(long KwPerYear)
        {
            TarrifName = "Basic Electircity Tarriff";
            
            var basecoust = baseCostPerMonth * 12;
            var ConsumptionCost = 0.22 * KwPerYear;
           
            AnnualCosts = basecoust + ConsumptionCost;

        }
    }
}
