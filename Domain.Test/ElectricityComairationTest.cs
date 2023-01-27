using Domain.Tarrifs;
namespace Domain.Test
{
    [TestClass]
    public class ElectricityComairationTest
    {
        [TestMethod]

        public void callConsumption_retriveTarrifName()
        {
            List<Tarrif> expectedtarrif = new List<Tarrif>() { new PackageTarrifCalculator(3600), new BasicElectircityTarriffCalculator(3600) };
            
           ElectricityComairation consumption = new ElectricityComairation();


           var tarrifs= consumption.Consumption(3600);
            Assert.IsTrue(expectedtarrif.SequenceEqual(tarrifs));
           

        }

        [TestMethod]
  
        public void callConsumption_retrive3600Order()
        {
            List<Tarrif> expectedtarrif = new List<Tarrif>() { new PackageTarrifCalculator(3600), new BasicElectircityTarriffCalculator(3600) };

            ElectricityComairation consumption = new ElectricityComairation();


            var tarrifs = consumption.Consumption(3600);
            Assert.IsTrue(expectedtarrif.SequenceEqual(tarrifs));


        }

        [TestMethod]

        public void callConsumption_retrive6000Order()
        {
            List<Tarrif> expectedtarrif = new List<Tarrif>() {new BasicElectircityTarriffCalculator(6000), new PackageTarrifCalculator(6000) };

            ElectricityComairation consumption = new ElectricityComairation();


            var tarrifs = consumption.Consumption(6000);
            Assert.IsTrue(expectedtarrif.SequenceEqual(tarrifs));


        }

    }
}