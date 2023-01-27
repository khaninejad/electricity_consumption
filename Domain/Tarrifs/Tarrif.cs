namespace Domain.Tarrifs
{
    public abstract class Tarrif : IEquatable<Tarrif>
    {
        public string TarrifName { get; set; }
        public double AnnualCosts { get; set; }

        public bool Equals(Tarrif? other)
        {
            return (string.Equals(TarrifName, other.TarrifName) && AnnualCosts == other.AnnualCosts);

        }
    }
}
