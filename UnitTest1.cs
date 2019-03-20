using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GarageFix;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);
            Car a = new Car("toyota", false, true);
           cars.AddCar(a);
            foreach(Car x in cars)
            {
                Assert.AreEqual(x, a);
            }
        }
        [TestMethod]
        [ExpectedException(exceptionType:typeof(CarNullException))]
        public void TestException1()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);
            Car a = null;
            cars.AddCar(a);

        }
        [TestMethod]
        [ExpectedException(exceptionType: typeof(CarAlreadyExistExceptoin))]
        public void TestException2()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);
            Car a = new Car("toyota", false, true);
            cars.AddCar(a);
            cars.AddCar(a);
          
        }
        [TestMethod]
        [ExpectedException(exceptionType: typeof(WeDoNottFixTotalLosExecption))]
        public void TestException3()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);
            Car a = new Car("toyota", true, true);
            cars.AddCar(a);
            
        }
        [TestMethod]
        [ExpectedException(exceptionType: typeof(WrongGarageException))]
        public void TestException4()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);
            Car a = new Car("audi", false, true);
            cars.AddCar(a);

        }
        [TestMethod]
        [ExpectedException(exceptionType: typeof(RepairMissMatchException))]
        public void TestException5()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);
            Car a = new Car("toyota", false, false);
            cars.AddCar(a);

        }
        [TestMethod]
        
        public void TakeOutCar()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);
            Car a = new Car("toyota", false, true);
            cars.AddCar(a);
            cars.FixCar(a);
            cars.TakeOutCar(a);
            foreach(Car x in cars)
            {
                Assert.IsTrue(false);
            }

        }
        [TestMethod]
        public void FixCar()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);
            Car a = new Car("toyota", false, true);
            cars.AddCar(a);
            cars.FixCar(a);
            foreach (Car x in cars)
            {
                Assert.IsTrue(a.NeedsRepair == false);
            }

        }

    }

}
