using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9.Management_System
{
    public static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }
    }
}