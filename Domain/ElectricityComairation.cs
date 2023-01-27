
using Domain.Tarrifs;

namespace Domain
{
    public class ElectricityComairation
    {
        public List<Tarrif> Consumption(long KwPerYear)
        {
            List<Tarrif> tarrifs = new List<Tarrif>
            {
                new BasicElectircityTarriffCalculator(KwPerYear),
                new PackageTarrifCalculator(KwPerYear)
            };
            return tarrifs.OrderBy(a=>a.AnnualCosts).ToList();
        }
    }
}
