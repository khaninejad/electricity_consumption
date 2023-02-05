namespace Domain.Tarrifs
{
    public abstract class Tariff : IEquatable<Tariff>
    {
        public string TariffName { get; set; }
        public double AnnualCosts { get; set; }

        public bool Equals(Tariff? other)
        {
            if (other == null)
                return false;

            return (string.Equals(TariffName, other.TariffName) && AnnualCosts == other.AnnualCosts);
        }
    }
}