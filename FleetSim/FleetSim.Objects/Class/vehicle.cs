using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Interface;
using FleetSim.Objects.Enum;

namespace FleetSim.Objects.Class
{
    public class vehicle : iVehicle
    {
        private string VIN;
        private int Mileage;
        //public enum Color { red, white, blue };
        public string carColor;
        private DateTime LastServicedDate;
        private int LastServicedMileage;

        public vehicle()
        {
            VIN = Guid.NewGuid().ToString();
            Mileage = 0;
            LastServicedDate = DateTime.Today;
            LastServicedMileage = 0; 
        }
        public void TuneUp()
        {
            if (Mileage - LastServicedMileage >= 30000)
            {
                LastServicedDate = DateTime.Now;
                LastServicedMileage = Mileage;
                Console.WriteLine($"Vehicle tuned up at {LastServicedMileage} on {LastServicedDate}");
            }
            if (Mileage >= 100000)
            {
                EngineRebuild();
            }
        }
        virtual public void EngineRebuild()
        {
            Mileage = 0;
            LastServicedMileage = 0;
            Console.WriteLine($"Engine rebuilt on {LastServicedDate}");
        }
        public string _VIN
          {
             get
              {
                  return this.VIN;
              }
              set
              {
                  value = Guid.NewGuid().ToString();
              }
          }
        public int _Mileage
        {
            get
            {
                return this.Mileage;
            }
            set
            {
                if (value < 0 || value > 750000)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be a valid Mileage");
                }
                Mileage = value;
            }
        }
       public DateTime _LastServicedDate
        {
            get
            {
                return this.LastServicedDate;
            }
            set
            {
                value = DateTime.Now;
            }
        }
        public int _LastServicedMileage
        {
            get
            {
                return this.LastServicedMileage; 
            }
            set
            {
                value = LastServicedMileage;
            }
        }
       /* public string _carColor
        {
            get
            {
                return this.carColor;
            }
            set
            {
                value = carColor;
            }
        }*/
        
    }
}
