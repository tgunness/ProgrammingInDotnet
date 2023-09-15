using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipConsoleApp
{
    public class Dealership
    {
        private Car[] _allCars;

        public Dealership()
        {
            _allCars = new Car[5];
            _allCars[0] = new Car("Honda", "Civic", 40, 550);
            _allCars[1] = new Car("Ford", "Mustang", 45, 432);
            _allCars[2] = new Car("VW", "Golf", 34, 667);
            _allCars[3] = new Car("Ford", "Focus", 39, 600);
            _allCars[4] = new Car("Chevrolet", "Cruz", 40, 525);
        }
        public Car[] GetAllCars()
        {
            return _allCars;
        }

        public Car GetBestMileageCar()
        {
            Car bestCar = _allCars[0];

            foreach(Car car in _allCars)
            {
                if(car.CalculateFuelEfficiency() <= bestCar.CalculateFuelEfficiency())
                {
                    bestCar = car;
                }
            }

            return bestCar;
        }

        public Car[] GetCarByMake(string make)
        {
            Car[] makeCars = new Car[5];
            int index = 0;
            foreach(Car car in _allCars)
            {
                if (car.Make.Equals(make, StringComparison.CurrentCultureIgnoreCase))
                {
                    makeCars[index] = car;
                    index++;
                }
            }
            return makeCars;
        }

    }
}
