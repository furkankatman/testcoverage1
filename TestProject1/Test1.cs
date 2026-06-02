using Microsoft.VisualStudio.TestTools.UnitTesting;
using testcoverage1;


namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CarChangesGear_OnGearUp()
        {
            Car car1 = new Car();
            car1.GearUp();
            StringAssert.Contains(car1.ShowStateAsString(), "Gear: 1");
        }

        [TestMethod]
        public void CarChangesGear_OnGearDown()
        {
            Car car1 = new Car();
            car1.GearUp();
            car1.GearDown();
            StringAssert.Contains(car1.ShowStateAsString(), "Gear: 0");
        }

        [TestMethod]
        public void CarDoesntChangeGear_OnGearDown_WhenInNeutral()
        {
            Car car1 = new Car();
            car1.GearDown();
            StringAssert.Contains(car1.ShowStateAsString(), "Gear: 0");
        }

        [TestMethod]
        public void CarTogglesLights()
        {
            Car car1 = new Car();
            car1.ToggleLights();
            StringAssert.Contains(car1.ShowStateAsString(), "Lights: ON");
            car1.ToggleLights();
            StringAssert.Contains(car1.ShowStateAsString(), "Lights: OFF");
        }

        [TestMethod]
        public void CarAccelerates()
        {
            Car car1 = new Car();
            car1.Accelerate(20);
            StringAssert.Contains(car1.ShowStateAsString(), "Speed: 20 km/h");
        }

        [TestMethod]
        public void CarBrakes()
        {
            Car car1 = new Car();
            car1.Accelerate(20);
            car1.Brake(5);
            StringAssert.Contains(car1.ShowStateAsString(), "Speed: 15 km/h");
            car1.Brake(20);
            StringAssert.Contains(car1.ShowStateAsString(), "Speed: 0 km/h");
        }
    }
}
