using FluentAssert;
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
            car1.ShowStateAsString().ToLower().ShouldContain("gear: 1");
        }
    }
}
