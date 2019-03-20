using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageFix
{
    public interface IGarage<Car>
    {
        void AddCar(Car car );
        void TakeOutCar(Car car );
        void FixCar(Car car );
         
    }
    public interface INameable
    {
        string Brand { get; }
        bool TotallLost { get; }
        bool NeedsRepair { get; set; }
    }

}
