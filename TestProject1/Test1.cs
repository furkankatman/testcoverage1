using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;
using testcoverage1;


namespace TestProject1
{
    [TestClass]
    [DoNotParallelize]
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

        [TestMethod]
        public void CarStateAsStringIsShownCorrectly()
        {
            Car car1 = new Car();
            car1.GearUp();
            car1.Accelerate(30);
            car1.ToggleLights();
            string expectedState = "Gear: 1, Speed: 30 km/h, Lights: ON";
            Assert.AreEqual(expectedState, car1.ShowStateAsString());
        }

        [TestMethod]
        public void CarStateLogsOnConsole()
        {

            var originalOut = Console.Out;

            try
            {
                Car car1 = new Car();
                car1.GearUp();
                car1.Accelerate(30);
                car1.ToggleLights();
                var sw = new StringWriter();
                Console.SetOut(sw);

                car1.ShowState();
                string expectedLog = """
                ---- Car State ----
                Gear: 1
                Speed: 30 km/h
                Lights: ON
                -------------------
                """;
                Assert.AreEqual(expectedLog.Trim(), sw.ToString().Trim());
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }

        [TestMethod]
        public async Task CarOpensSunroof()
        {
            var originalOut = Console.Out;

            try
            {
                Car car1 = new Car();
                var sw = new StringWriter();
                Console.SetOut(sw);

                bool result = await car1.SunroofOpen();

                Assert.IsTrue(result);
                StringAssert.Contains(sw.ToString(), "Sunroof is now open.");
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }


    }
}
