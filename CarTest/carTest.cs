using CarNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarTest
{
    [TestClass]
    public class carTest
    {
        [TestMethod]
        public void emptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        [TestMethod]
        public void TestInitialGasTank()
        {
            Car test_car = new Car("toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            Car test_car = new Car("toyota", "Prius", 10, 50);
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        [TestMethod]
        public void TestGastTankAfterExcedingTankRange()
        {
            Car test_car = new Car("toyota", "Prius", 10, 50);
            test_car.Drive(510);
            Assert.AreEqual(0, test_car.GasTankLevel, .001);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            Car test_car = new Car("toyota", "Prius", 10, 50);
            test_car.AddGas(6);
            
        }

    }  
    

  
}
