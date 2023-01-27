using Domain.Tarrifs;

namespace Domain.Test
{
    [TestClass]
    public class BasicElectircityTarriffCalculatorTest
    {
        [TestMethod]
        public void CreateBasicElectircityTarriffCalculator_retriveTarrifName()
        {
            var tarrif = new BasicElectircityTarriffCalculator(3600);
            Assert.AreEqual(tarrif.TarrifName, "Basic Electircity Tarriff");
        }
        [TestMethod]
        [DataRow(3500, 830)]
        [DataRow(4500, 1050)]
        [DataRow(6000, 1380)]
        public void CreateBasicElectircityTarriffCalculator_retriveAnnualCosts(long kwPerYear, double AssertResault)
        {
            var tarrif = new BasicElectircityTarriffCalculator(kwPerYear);
            Assert.AreEqual(tarrif.AnnualCosts, AssertResault);
        }
    }
}