using Domain.Tarrifs;
namespace Domain.Test
{
    [TestClass]
    public class ElectricityComairationTest
    {
        [TestMethod]

        public void callConsumption_retriveTarrifName()
        {
            List<Tariff> expectedtarrif = new List<Tariff>() { new PackageTariffCalculator(3600), new BasicElectricityTariffCalculator(3600) };

            ElectricityComparison consumption = new ElectricityComparison();


           var tarrifs= consumption.Compare(3600);
            Assert.IsTrue(expectedtarrif.SequenceEqual(tarrifs));
           

        }

        [TestMethod]
  
        public void callConsumption_retrive3600Order()
        {
            List<Tariff> expectedtarrif = new List<Tariff>() { new PackageTariffCalculator(3600), new BasicElectricityTariffCalculator(3600) };

            ElectricityComparison consumption = new ElectricityComparison();


            var tarrifs = consumption.Compare(3600);
            Assert.IsTrue(expectedtarrif.SequenceEqual(tarrifs));


        }

        [TestMethod]

        public void callConsumption_retrive6000Order()
        {
            List<Tariff> expectedtarrif = new List<Tariff>() {new BasicElectricityTariffCalculator(6000), new PackageTariffCalculator(6000) };

            ElectricityComparison consumption = new ElectricityComparison();


            var tarrifs = consumption.Compare(6000);
            Assert.IsTrue(expectedtarrif.SequenceEqual(tarrifs));


        }

    }
}