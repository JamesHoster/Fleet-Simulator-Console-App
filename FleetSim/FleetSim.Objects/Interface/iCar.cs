using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Objects.Interface
{
    interface iCar
    {
        int _year { get; set; }
        string _make { get; set; }
        string _model { get; set; }

    }
}
