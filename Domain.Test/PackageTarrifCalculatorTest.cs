using Domain.Tarrifs;

namespace Domain.Test
{
    [TestClass]
    public class PackageTarrifCalculatorTest
    {
        [TestMethod]
        public void CreatePackageTarrifCalculator_retriveTarrifName()
        {
            var tarrif = new PackageTarrifCalculator(3600);
            Assert.AreEqual(tarrif.TarrifName, "Package Tarrif");
        }
        [TestMethod]
        [DataRow(3500, 800)]
        [DataRow(4500, 950)]
        [DataRow(6000, 1400)]
        public void CreatePackageTarrifCalculator_retriveAnnualCosts(long kwPerYear, double AssertResault)
        {
            var tarrif = new PackageTarrifCalculator(kwPerYear);
            Assert.AreEqual(tarrif.AnnualCosts, AssertResault);
        }
    }
}