using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
        public static void PrintShipment(IInsurable shipment)
        {
            Console.WriteLine($"IInsurable cost {shipment.CalculateInsurance()}");
        }

    }
}
