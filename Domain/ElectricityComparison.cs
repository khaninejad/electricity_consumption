
using Domain.Tarrifs;

namespace Domain
{
    public class ElectricityComparison
    {
        public List<Tariff> Compare(long kwPerYear)
        {
            List<Tariff> tariffs = new List<Tariff>
            {
                new BasicElectricityTariffCalculator(kwPerYear),
                new PackageTariffCalculator(kwPerYear)
            };
            return tariffs.OrderBy(t => t.AnnualCosts).ToList();
        }
    }
}
