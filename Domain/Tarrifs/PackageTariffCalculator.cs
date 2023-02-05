using Domain.Tarrifs;

namespace Domain.Tarrifs
{
    public class PackageTariffCalculator : Tariff
    {
        private const long BaseKWPerYear = 4000;
        public PackageTariffCalculator(long kwPerYear)
        {
            try
            {
                TariffName = "Package Tariff";
                AnnualCosts = 800 + (Math.Max(0, (kwPerYear - BaseKWPerYear)) * .30);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in PackageTariffCalculator: " + ex.Message);
                throw;
            }
        }
    }
}