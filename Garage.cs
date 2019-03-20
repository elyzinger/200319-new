using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageFix
{
    public class Garage<Car> : IGarage<Car>, IEnumerable<Car> where Car : INameable 
    {
        public List<Car> cars;
        public List<string> carTypes;

        public Garage(List<string> carTypes)
        {
            cars = new List<Car>();
           // carTypes = new List<string>();
            this.carTypes = carTypes;
        }
        public void AddCar(Car car)
        {
            if (car == null)
            {
                throw new CarNullException("we do not fix this brand");
            }
            if (cars.Contains(car))
            {
                throw new CarAlreadyExistExceptoin($"car: {car} alredy exist");
            }
            if (car.TotallLost == true)
            {
                throw new WeDoNottFixTotalLosExecption("we do not fix total lost");
            }
            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException("wrong garage");
            }
           
            if (car.NeedsRepair == false)
            {
                throw new RepairMissMatchException("car dont need repair");
            }
            if (carTypes.Contains(car.Brand))
            {
                cars.Add(car);
            }
        }
        public void TakeOutCar(Car car)
        {
            if (car == null)
            {
                throw new CarNullException("we do not fix this brand");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException("not in garage");
            }
            
            if (car.NeedsRepair == true)
            {
                throw new CarNotReadyException("car not ready");
            }
            cars.Remove(car);

        }
        public void FixCar(Car car)
        {
            
            if (car == null)
            {
                throw new CarNullException("we do not fix this brand");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException("not in garage");
            }

            if (car.NeedsRepair == false)
            {
                throw new RepairMissMatchException("car dont need repair");
            }          
           
                
               car.NeedsRepair = false;
            
                         
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cars.GetEnumerator();
        }
    }
}
