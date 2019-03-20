using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageFix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("toyota");
            carTypes.Add("honda");
            Garage<Car> cars = new Garage<Car>(carTypes);

            cars.AddCar(new Car("toyota", false, true));

            
            try
            {
                cars.AddCar(new Car("audi", false, true));
            }
            catch (WrongGarageException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("hi");
            Console.ReadLine();
            
            
        }   
    }
}
