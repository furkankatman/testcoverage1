using Microsoft.VisualStudio.TestTools.UnitTesting;
using testcoverage1;


namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CarChangesGear_onGearUp()
        {
            Car car1 = new Car();
            car1.GearUp();
            StringAssert.Contains(car1.ShowStateAsString(), "Gear: 1");
        }

        [TestMethod]
        public void CarChangesGear_onGearDown()
        {
            Car car1 = new Car();
            car1.GearUp();
            car1.GearDown();
            StringAssert.Contains(car1.ShowStateAsString(), "Gear: 0");
        }
    }
}
