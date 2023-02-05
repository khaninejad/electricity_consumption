using Domain.Tarrifs;

namespace Domain.Test
{
    [TestClass]
    public class BasicElectircityTarriffCalculatorTest
    {
        [TestMethod]
        public void CreateBasicElectircityTarriffCalculator_retriveTarrifName()
        {
            var tarrif = new BasicElectricityTariffCalculator(3600);
            Assert.AreEqual(tarrif.TariffName, "Basic Electricity Tariff");
        }
        [TestMethod]
        [DataRow(3500, 830)]
        [DataRow(4500, 1050)]
        [DataRow(6000, 1380)]
        public void CreateBasicElectircityTarriffCalculator_retriveAnnualCosts(long kwPerYear, double AssertResault)
        {
            var tarrif = new BasicElectricityTariffCalculator(kwPerYear);
            Assert.AreEqual(tarrif.AnnualCosts, AssertResault);
        }
    }
}