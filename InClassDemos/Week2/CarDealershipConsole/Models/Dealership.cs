using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    /// <summary>
    /// Car Dealership is service that contains all business logic for the CarDealership app
    /// </summary>
    public class Dealership
    {
        private Car[] _cars;
        public Dealership() 
        {
            GenerateCars();
        }

        /// <summary>
        /// Initializes the Cars array with cars
        /// </summary>
        private void GenerateCars()
        {
            Car[] cars = new Car[5];
            cars[0] = new Car("Honda","Civic",40,550);
            cars[1] = new Car("Ford","Mustang",45,432);
            cars[2] = new Car("VW", "Golf", 34, 667);
            cars[3] = new Car("Ford", "Focus", 39, 600);
            cars[4] = new Car("Chevrolet","Cruz",40,525);
            _cars = cars;
        }

        /// <summary>
        /// Get all cars of Car Dealership
        /// </summary>
        /// <returns>Car array with all cars at dealer</returns>
        public Car[] GetAllCars()
        {
            return _cars;
        }

        /// <summary>
        /// Gets the car with best mileage
        /// </summary>
        /// <returns>An instance of Car from array that represents best mileage</returns>
        public Car GetCarWithBestMileage()
        {
            Car bestFuelEfficientCar = _cars[0];
            foreach(Car car in _cars)
            {
                if(car.CalculateFuelEfficiency() <= bestFuelEfficientCar.CalculateFuelEfficiency())
                {
                    bestFuelEfficientCar = car;
                }
            }

            return bestFuelEfficientCar;
        }

        /// <summary>
        /// Gets all Car by make
        /// </summary>
        /// <param name="make">String representation of make (ie. "Ford", "VW")</param>
        /// <returns>A subset of all cars that are of same make</returns>
        public Car[] GetAllCarsByMake(string make)
        {
            int count = 0;
            Car[] ret = null;

            foreach(Car car in _cars)
            {
                if(car.Make.Equals(make, StringComparison.OrdinalIgnoreCase))
                {
                    Array.Resize(ref ret, count+1);
                    ret[count] = car;
                    count++;
                }
            }

            return ret;
        }


    }
}
