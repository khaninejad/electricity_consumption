namespace Domain.Tarrifs
{
    public class PackageTarrifCalculator : Tarrif
    {
        public PackageTarrifCalculator(long KwPerYear)
        {
            TarrifName = "Package Tarrif";
            AnnualCosts = 800 + (Math.Max(0,(KwPerYear - 4000)) * .30);
        }

    }
}
