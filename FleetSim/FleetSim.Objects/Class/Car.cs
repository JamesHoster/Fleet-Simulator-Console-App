using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Interface;

namespace FleetSim.Objects.Class
{
    public class Car : vehicle, iVehicle, iCar
    {
        private int year;
        private string make;
        private string model;

        public void setCarDetail(int year, string make, string model)
        {
            year = _year;
            make = _make;
            model = _model;
        }
        public int _year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }
        public string _make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string _model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

    }
}
