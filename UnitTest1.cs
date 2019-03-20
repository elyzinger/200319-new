using GarageFix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.ConstrainedExecution;

namespace TestGarage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //[ExpectedException(exceptionType: typeof(CarAlreadyExistExceptoin))]
        public void TestAddCar()
        {
            
           Assert.cars.AddCar(new Car("toyota", false, true));
            cars.
            
        }
    }
}
