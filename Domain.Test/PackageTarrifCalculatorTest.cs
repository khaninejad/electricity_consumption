using Domain.Tarrifs;

namespace Domain.Test
{
    [TestClass]
    public class PackageTarrifCalculatorTest
    {
        [TestMethod]
        public void CreatePackageTarrifCalculator_retriveTarrifName()
        {
            var tarrif = new PackageTariffCalculator(3600);
            Assert.AreEqual(tarrif.TariffName, "Package Tariff");
        }
        [TestMethod]
        [DataRow(3500, 800)]
        [DataRow(4500, 950)]
        [DataRow(6000, 1400)]
        public void CreatePackageTarrifCalculator_retriveAnnualCosts(long kwPerYear, double AssertResault)
        {
            var tarrif = new PackageTariffCalculator(kwPerYear);
            Assert.AreEqual(tarrif.AnnualCosts, AssertResault);
        }
    }
}