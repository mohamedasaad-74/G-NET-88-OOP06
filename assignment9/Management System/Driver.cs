using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public class Driver
    {
        public string DriverId { get; set; }
        public string Name { get; set; }

        public Driver(string driverId, string name)
        {
            DriverId = driverId;
            Name = name;
        }
    }
}