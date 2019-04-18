using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Class;
using FleetSim.Objects.Enum;

namespace FleetSim
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                string carGuid = Guid.NewGuid().ToString();
                var cars = new List<Car>
            {
                new Car() {_year=1975, _make="DMC", _model="Delorean", carColor=_carColor.blue.ToString(), _VIN = carGuid, _Mileage = 0},
                new Car() {_year=2012, _make="Cheverolet", _model="Malibu", carColor=_carColor.blue.ToString(), _VIN = carGuid, _Mileage = 0},
                new Car() {_year=1997, _make="Toyota", _model="Corolla", carColor=_carColor.red.ToString(), _VIN= carGuid, _Mileage = 0 },
                new Car() {_year=2019, _make="Tesla" , _model="Model 3", carColor=_carColor.white.ToString(), _VIN=carGuid, _Mileage =0 },
                new Car() {_year=2007, _make="Pontiac", _model = "Grand Prix", carColor=_carColor.white.ToString(), _VIN=carGuid, _Mileage = 0 }
            };

                Random rnd = new Random();
                int Index = 0;
                do
                {
                    for (int count = 1; count <= 10; count++)
                    {
                        cars[Index]._Mileage += rnd.Next(5000, 15000);

                        cars[Index].TuneUp();

                        Console.WriteLine($"{cars[Index]._year}  {cars[Index]._make}   {cars[Index]._model}   {cars[Index].carColor}   {cars[Index]._VIN}   {cars[Index]._Mileage}");
                    }
                    Index++;
                    Console.WriteLine();
                } while (Index <= cars.Count - 1);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("An Error has occured. Please contact support for help.");
            }
        }
    }

}
